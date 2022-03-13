using System;

namespace _2.__Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long result = 0;
            int length = Math.Min(input[0].Length, input[1].Length);
            for (int i = 0; i < length; i++)
            {
                result += input[0][i] * input[1][i];
            }
            if (input[0].Length > length)
            {
                for (int i = length; i < input[0].Length; i++)
                {
                    result += input[0][i];
                }
            }
            if (input[1].Length > length)
            {
                for (int i = length; i < input[1].Length; i++)
                {
                    result += input[1][i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
