using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string phonesnumber = Console.ReadLine();
            MatchCollection matches = Regex.Matches(phonesnumber, regex);
            List<string> result = new List<string>();
            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }
            // string[] maches = Regex.Matches(phonesnumber, regex).Select(m => m.Value).ToArray();    14 - 19 row
            Console.WriteLine(string.Join(", ", result));   
        }
    }
}
