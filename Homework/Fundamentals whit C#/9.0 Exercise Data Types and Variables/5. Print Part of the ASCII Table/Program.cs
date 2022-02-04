using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            char cH = ' ';
            for (int i = start; i <= stop; i++)
            {
                cH = (char)i;
                Console.Write($"{cH} ");               
            }
        }
    }
}
