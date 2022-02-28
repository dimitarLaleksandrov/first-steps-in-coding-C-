using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Random random = new Random();
            for (int i = 0; i < words.Count; i++)
            {
                int randomIndex = random.Next(0, words.Count);
                string curentWord = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = curentWord;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
