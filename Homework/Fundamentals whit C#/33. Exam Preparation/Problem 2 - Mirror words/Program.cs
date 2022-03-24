using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2___Mirror_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(@|#)([a-zA-Z]{3,})\1\1([a-zA-Z]{3,})\1");
            string words = Console.ReadLine();
            MatchCollection matches = pattern.Matches(words);
            List<string[]> result = new List<string[]>();
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            foreach (Match match in matches)
            {
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[3].Value;
                string reversedSecondWord = string.Join("", secondWord.Reverse());
                if (firstWord == reversedSecondWord)
                {
                    result.Add(new string[] { firstWord, secondWord });
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                string[] messages = result.Select(word => $"{word[0]} <=> {word[1]}").ToArray();
                Console.WriteLine($"The mirror words are: ");
                Console.WriteLine(string.Join(", ", messages));
            }
        }
    }
}
