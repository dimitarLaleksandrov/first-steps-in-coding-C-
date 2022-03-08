using System;
using System.Collections.Generic;

namespace _3._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            for (int i = 1; i <= counter; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, new List<string>());
                }      
                dictionary[key].Add(value);
            }
            foreach (var keyAndValue in dictionary)
            {
                Console.WriteLine($"{keyAndValue.Key} - {string.Join(", ", keyAndValue.Value)}");
            }
        }
    }
}
