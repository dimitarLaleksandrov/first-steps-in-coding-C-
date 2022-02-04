using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int value = input[i];
                if (value % 2 == 0)
                {
                    sum += value;
                }
            }
            Console.WriteLine(sum);
            //foreach (int item in input)
            //{
            //    if (item % 2 == 0)
            //    {
            //        sum += item;
            //    }
            //}
        }
    }
}
