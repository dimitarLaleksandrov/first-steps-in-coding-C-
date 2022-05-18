using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            int numberN = input[0];
            int numberS = input[1];
            int numberX = input[2];
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < numberN; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < numberS; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(numberX))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
