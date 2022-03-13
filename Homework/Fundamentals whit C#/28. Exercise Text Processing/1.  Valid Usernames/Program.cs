using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.__Valid_Usernames
{
    internal class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^(\w+(-\w*)*)$");
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string>  validUsername = new List<string>();
            foreach (var name in usernames)
            {
                if (pattern.IsMatch(name) && (name.Length >= 3 && name.Length <= 16))
                {
                    validUsername.Add(name);
                }
            }
            Console.WriteLine(String.Join("\n", validUsername));
        }
    }
}
