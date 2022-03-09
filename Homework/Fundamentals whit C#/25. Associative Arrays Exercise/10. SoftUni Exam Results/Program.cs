using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languageAndSubmitions = new Dictionary<string, int>();
            Dictionary<string, int> usersAndPoints = new Dictionary<string, int>();
            string inputLine = Console.ReadLine();
            while (inputLine != "exam finished")
            {
                string[] inputArr = inputLine.Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = inputArr[0];
                if (inputArr[1] != "banned")
                {
                    string language = inputArr[1];
                    int poits = int.Parse(inputArr[2]);
                    if (!usersAndPoints.ContainsKey(user))
                    {
                        usersAndPoints.Add(user, 0);
                    }
                    if (poits > usersAndPoints[user])
                    {
                        usersAndPoints[user] = poits;
                    }
                    if (!languageAndSubmitions.ContainsKey(language))
                    {
                        languageAndSubmitions.Add(language, 0);
                    }
                    languageAndSubmitions[language]++;
                }
                else
                {
                    if (usersAndPoints.ContainsKey(user))
                    {
                        usersAndPoints.Remove(user);
                    }
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var user in usersAndPoints.OrderByDescending(user => user.Value).ThenBy(user => user.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }
            Console.WriteLine($"Submissions:");
            foreach (var langiage in languageAndSubmitions.OrderByDescending(langiage => langiage.Value).ThenBy(langiage => langiage.Key))
            {
                Console.WriteLine($"{langiage.Key} - {langiage.Value}");
            }
        }
    }
}
