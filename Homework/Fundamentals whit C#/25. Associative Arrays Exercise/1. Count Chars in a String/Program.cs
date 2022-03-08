using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = string.Join(string.Empty, Console.ReadLine().Split(" "));           
            Dictionary<char, int> occurrencesWord = new Dictionary<char, int>();
            foreach (var symbol in words)
            {
                if (!occurrencesWord.ContainsKey(symbol))
                {
                    occurrencesWord.Add(symbol, 0);
                }
                occurrencesWord[symbol]++;
            }
            foreach (var occurrence in occurrencesWord)
            {
                Console.WriteLine($"{occurrence.Key} -> {occurrence.Value}");
            }
            
        }
    }
}
