using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberN = input[0];
            int numberS = input[1];
            int numberX = input[2];
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>();
            for (int i = 0; i < numberN; i++)
            {
                nums.Push(numbers[i]);
            }
            for (int i = 0; i < numberS; i++)
            {
                nums.Pop();
            }
            if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (nums.Contains(numberX))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}
