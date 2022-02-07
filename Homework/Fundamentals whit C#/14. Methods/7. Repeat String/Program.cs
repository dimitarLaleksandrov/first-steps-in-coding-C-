using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int repeats = 0;
            StringMethod(input , repeats);
        }
        static string StringMethod(string input, int repeats)
        {
            string lord = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            for (int i = 1; i <= times; i++)
            {
                Console.Write($"{lord}");
            }
            return lord;
        }
    }
}
