using System;
using System.Text.RegularExpressions;

namespace _0._0_Regex_sintaksis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "I am 22 years old and 19218288njkbj and you are 20 years old";
            string pattern = @"\b\d+\b";
            Match match = Regex.Match(text, pattern);
            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine("Match value: " + match.Value);
            foreach (Match currentMatch in matches) 
            {
                Console.WriteLine("Current match is: " + currentMatch.Value);
            }
            if (Regex.IsMatch(text, pattern))
            {
                Console.WriteLine("Yes we have match!");
            }
        }
    }
}
