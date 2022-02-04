using System;

namespace _4._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string revurs = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                revurs += input[i];
            }
            Console.WriteLine(revurs);
        }
    }
}
