using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Clean_string_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[]{ };
            Console.WriteLine(string.Join("", CleanString(words)));
        }
        static List<string> CleanString(string[] words)
        {
            string[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            List<string> clearWords = new List<string>();
            List<string> charList = new List<string>();
            foreach (var word in input)
            {
                foreach (char ch in word)
                {
                    if (!char.IsLetter(ch))
                    {
                        break;
                    }
                    else
                    {
                        charList.Add(ch.ToString());
                    }
                }
                if (charList.Count < word.Length)
                {
                    charList.RemoveRange(0, charList.Count);
                }
                if (charList.Count > 0)
                {
                    string charWord = string.Join("", charList);
                    clearWords.Add(charWord);
                }
                if (charList.Count - 1 > 0)
                {
                    
                    charList.RemoveRange(0, charList.Count);
                    clearWords.Insert(clearWords.Count, ",");
                }
            }
            clearWords.RemoveAt(clearWords.Count - 1);
            return clearWords;
        }
    }
}
