using System;

namespace _2._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
