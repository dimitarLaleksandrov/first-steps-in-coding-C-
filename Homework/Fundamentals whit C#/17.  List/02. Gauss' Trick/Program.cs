using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < input.Count / 2; i++)
            {
                int newNum = input[i] + input[input.Count - 1 - i];
                result.Add(newNum);
            }
            if (input.Count % 2 != 0)
            {
                result.Add(input[input.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
