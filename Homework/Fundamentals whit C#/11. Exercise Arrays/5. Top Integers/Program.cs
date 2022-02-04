using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] topArray = new int[input.Length];
            int topDigit = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];
                bool flag = true;
                for (int j = i + 1; j < input.Length; j++)
                {
                    int nextNum = input[j];
                    if (currentNum <= nextNum)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    topArray[topDigit] = currentNum;
                    topDigit++;
                }
            }
            for (int i = 0; i < topDigit; i++)
            {
                Console.Write($"{topArray[i]} ");
            }           
        }
    }
}
