using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int longestCount = Math.Max(firstLine.Count, secondLine.Count);
            List<int> result = new List<int>();
            for (int i = 0; i < longestCount; i++)
            {
                if (i < firstLine.Count)
                {
                    result.Add(firstLine[i]);
                }
                if (i < secondLine.Count)
                {
                    result.Add(secondLine[i]);
                }                             
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
