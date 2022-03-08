using System;
using System.Linq;

namespace _4._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] filtredWords = words.Where(word => word.Length % 2 == 0).ToArray();
            foreach (string word in filtredWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
