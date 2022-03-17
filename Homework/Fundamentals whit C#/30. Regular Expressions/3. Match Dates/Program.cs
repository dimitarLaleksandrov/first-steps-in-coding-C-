using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})(\.|-|\/)([A-z][a-z]{2})\2(\d{4})\b";
            // \b(?<day>\d{2})(\.|-|\/)(?<month>[A-z][a-z]{2})\1(?<year>\d{4})\b;
            string inputDate = Console.ReadLine();
            MatchCollection matchs = Regex.Matches(inputDate, pattern);
            foreach (Match mach in matchs)
            {
                string day = mach.Groups[1].Value;
                string month = mach.Groups[3].Value;
                string year = mach.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
