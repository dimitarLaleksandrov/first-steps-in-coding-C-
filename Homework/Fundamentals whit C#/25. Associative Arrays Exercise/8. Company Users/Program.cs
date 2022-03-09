using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            while (input[0] != "End")
            {
                string companyName = input[0];
                string employeeId = input[1];
                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }
                if (!company[companyName].Contains(employeeId))
                {
                    company[companyName].Add(employeeId);
                }
                input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach(var kvp in company)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var employeeId in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeId}");

                }
            }
        }
    }
}
