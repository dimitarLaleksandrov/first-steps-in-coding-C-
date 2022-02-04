using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumOfChar = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= NumOfChar; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int charektCode = (int)currentChar;
                sum += charektCode;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
