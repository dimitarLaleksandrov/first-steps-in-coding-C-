using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int alphabet = 0; alphabet < input.Length; alphabet++)
            {
                char letter = input[alphabet];
                Console.WriteLine(letter);

            }
        }
    }
}
