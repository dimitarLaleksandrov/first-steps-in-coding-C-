using System;

namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string occurrences = Console.ReadLine();
            string word = Console.ReadLine();
            while (word.Contains(occurrences))
            {
                int index = word.IndexOf(occurrences);
                word = word.Remove(index, occurrences.Length);
            }
            Console.WriteLine(word);
        }
    }
}
