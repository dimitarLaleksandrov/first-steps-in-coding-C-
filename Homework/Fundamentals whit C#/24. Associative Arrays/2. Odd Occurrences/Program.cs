using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string wordInlowerCase = word.ToLower();
                if (counts.ContainsKey(wordInlowerCase))
                {
                    counts[wordInlowerCase]++;
                    continue;
                }
                counts.Add(wordInlowerCase, 1);
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.WriteLine($"{count.Key} ");
                }    
            }
        }
    }
}
