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
        //private static bool validation(string username)
        //{
        //    if (username.Length < 3 || username.Length > 16)
        //    {
        //        return false;
        //    }
        //    bool isValid = true;
        //    for (int i = 0; i < username.Length; i++)
        //    {
        //        char curr = username[i];
        //        if (!(char.IsLetterOrDigit(curr) || curr == '-' || curr == '_'))
        //        {
        //            isValid = false;
        //            break;
        //        }
        //    }
        //    return isValid;
        //}
    }
}
