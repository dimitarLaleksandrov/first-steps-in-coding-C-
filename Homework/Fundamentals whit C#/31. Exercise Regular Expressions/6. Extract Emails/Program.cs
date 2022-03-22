using System;
using System.Text.RegularExpressions;

namespace _6._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex emailRegex = new Regex(@"(\s[a-z]+[\w.-]+\w)@([a-z]+[-a-z]*?([.][a-z]+)+)\b");
            string input = Console.ReadLine();
            Console.WriteLine(string.Join(Environment.NewLine, emailRegex.Matches(input)));
        }
    }
}
