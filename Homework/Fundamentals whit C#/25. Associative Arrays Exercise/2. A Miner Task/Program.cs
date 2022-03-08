using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recource = String.Empty;
            Dictionary<string, long> recourceQuantity = new Dictionary<string, long>();
            while ((recource = Console.ReadLine()) != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (!recourceQuantity.ContainsKey(recource))
                {
                    recourceQuantity.Add(recource, 0);
                    // recorceQuantity[recource] = 0;
                }
                recourceQuantity[recource] += quantity;
            }
            foreach (var kvp in recourceQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
