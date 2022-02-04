using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLetters = int.Parse(Console.ReadLine());
            for (int i = 0; i < numLetters ; i++)
            {
               char furst = (char)('a' + i);
                for (int j = 0; j < numLetters ; j++)
                {
                    char second = (char)('a' + j);
                    for (int k = 0; k < numLetters; k++)
                    {
                        char therd = (char)('a' + k);
                        Console.WriteLine($"{furst}{second}{therd}");
                    }
                }
            }
            
        }
    }
}
