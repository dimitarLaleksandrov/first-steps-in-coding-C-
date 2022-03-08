using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._1_Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 0);
                }
                words[word]++;
            }
            List<string> result = new List<string>();
            foreach (var word in words.Where(word => word.Value % 2 != 0))
            {
                result.Add(word.Key);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
