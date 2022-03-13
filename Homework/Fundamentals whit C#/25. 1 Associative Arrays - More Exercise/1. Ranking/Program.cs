using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contest = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> username = new Dictionary<string, Dictionary<string, int>>();
            string[] contestInput = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            while(contestInput[0] != "end of contests")
            {
                string key = contestInput[0];
                string password = contestInput[1];
                if (!contest.ContainsKey(key))
                {
                    contest.Add(key, password);
                }
                contestInput = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }
            string[] input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "end of submissions")
            {
                string contestName = input[0];
                string password = input[1];
                string userName = input[2];
                int points = int.Parse(input[3]);
                if (contest.ContainsKey(input[0]))
                {
                    if (contest.ContainsValue(input[1]))
                    {                       
                        if (!username.ContainsKey(userName))
                        {
                            username.Add(userName, new Dictionary<string, int>());
                        }
                        if (!username[userName].ContainsKey(contestName))
                        {
                            username[userName].Add(contestName, 0);
                        }
                        if (username[userName][contestName] < points)
                        {
                            username[userName][contestName] = points;
                        }
                    }
                }
                input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }
            Dictionary<string, int> bestPlayer = new Dictionary<string, int>();
            foreach (var user in username)
            {
                bestPlayer[user.Key] = user.Value.Values.Sum();
            }
            string bestUsername = bestPlayer.Keys.Max();
            int maxPoints = bestPlayer.Values.Max();
            foreach (var user in bestPlayer)
            {
                if (user.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {user.Key} with total {user.Value} points.");
                }
            }
            Console.WriteLine("Ranking:");
            foreach (var student in username.OrderBy(student => student.Key))
            {
                Console.WriteLine($"{student.Key}");
                foreach (var kvp in student.Value.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
