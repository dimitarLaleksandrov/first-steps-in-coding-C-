using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class CountSymbols
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            SortedDictionary<char, int> keyValuePairs = new SortedDictionary<char, int>();
            foreach (var c in chars)
            {
                if (!keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs.Add(c, 1);
                }
                else
                {
                    keyValuePairs[c]++;
                }
            }
            foreach (var c in keyValuePairs)
            {
                Console.WriteLine($"{c.Key}: {c.Value} time/s");
            }
        }
    }
}
