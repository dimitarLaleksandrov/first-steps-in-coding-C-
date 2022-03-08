using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal price = 0m;
            int quantity = 0;
            Dictionary<string, decimal[]> finalProduktPrice = new Dictionary<string, decimal[]>();
            while (input[0] != "buy")
            {
                price = decimal.Parse(input[1]);
                quantity = int.Parse(input[2]);
                if (!finalProduktPrice.ContainsKey(input[0]))
                {
                    finalProduktPrice.Add(input[0], new decimal[2]);
                }
                finalProduktPrice[input[0]][0] = price;
                finalProduktPrice[input[0]][1] += quantity;
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var kvp in finalProduktPrice)
            {
                decimal allPrice = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {allPrice:f2}");
            }
        }
    }
}
