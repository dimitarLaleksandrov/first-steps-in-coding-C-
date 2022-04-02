using System;
using System.Text.RegularExpressions;

namespace Problem_2___Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int dayCalories = 2000;
            Regex pattern = new Regex(@"(#|\|)(?<foodName>[A-Za-z\s]{1,})\1(?<dat>\d{2}/\d{2}/\d{2})\1(?<calories>\d{1,4}|10000)\1");
            string input = Console.ReadLine();
            MatchCollection matches = pattern.Matches(input);
            long caloories = 0;
            foreach (Match match in matches)
            {
                caloories += int.Parse(match.Groups["calories"].Value);
            }
            int dayLast = (int)Math.Abs(caloories / dayCalories);
            Console.WriteLine($"You have food to last you for: {dayLast} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["foodName"].Value}, Best before: {match.Groups["dat"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
