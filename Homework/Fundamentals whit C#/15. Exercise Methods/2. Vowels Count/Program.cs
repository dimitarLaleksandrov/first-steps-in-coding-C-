using System;
using System.Linq;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int counter = VawelsNumReturn(word);
            Console.WriteLine(counter);
        }
        static int VawelsNumReturn(string word)
        {
            char[] chars = new char[] {'a', 'e', 'i', 'o', 'u'};
            int counter = 0;
            foreach (char charekter in word.ToLower())
            {
                if (chars.Contains(charekter)) //char.ToLower == word.ToLower
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
