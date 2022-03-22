using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        private static object orderRegex;

        static void Main(string[] args)
        {
            Regex orderRegex = new Regex(@">>([A-Za-z]+)<<(\d+(\.\d+)?)\!(\d+)");
            List<string> purchased = new List<string>();
            decimal totalSpend = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                if (orderRegex.IsMatch(input))
                {
                    int amount = int.Parse(orderRegex.Match(input).Groups[4].ToString());
                    if (amount > 0)
                    {
                        string furnitureName = orderRegex.Match(input).Groups[1].ToString();
                        purchased.Add(furnitureName);
                        decimal price = decimal.Parse(orderRegex.Match(input).Groups[2].ToString());
                        totalSpend += price * amount;
                    }
                }
            }
            Console.WriteLine("Bought furniture:");
            if (purchased.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, purchased));
            }
            Console.WriteLine($"Total money spend: {totalSpend:F2}");
        }
    }
}
