using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2___Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(\=|\/)([A-Z][A-Za-z]{2,})\1");
            string input = Console.ReadLine();
            MatchCollection matches = pattern.Matches(input);
            List<string> destinaishans = new List<string>();
            int travelPoints = 0;
            foreach (Match match in matches)
            {
                string curentDestination = match.Groups[2].Value;
                destinaishans.Add(curentDestination);
                travelPoints += curentDestination.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinaishans)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
