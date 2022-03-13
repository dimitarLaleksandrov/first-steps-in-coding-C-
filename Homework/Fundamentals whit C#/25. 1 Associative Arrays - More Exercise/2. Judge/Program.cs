using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<string, int>> usernameParams = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> contestInfo = new Dictionary<string, int>();
            while (input[0] != "no more time")
            {
                string username = input[0];
                string contest = input[1];
                int point = int.Parse(input[2]);
                if (!usernameParams.ContainsKey(contest))
                {
                    usernameParams.Add(contest, new Dictionary<string, int>());
                }
                if (contestInfo.ContainsKey(contest))
                {
                    if (usernameParams[contest][username] < point && usernameParams[contest].ContainsKey(username))
                    {
                        usernameParams[contest][username] = point;
                    }
                    usernameParams[contest].Add(username, point);
                }
                input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var username in usernameParams)
            {
                int position = 1;
                foreach (var item in username.Value.OrderByDescending(item => item.Value))
                {
                    Console.WriteLine($"{position}  {item.Key}    {item.Value}");
                }
            }
        }
    }
}
