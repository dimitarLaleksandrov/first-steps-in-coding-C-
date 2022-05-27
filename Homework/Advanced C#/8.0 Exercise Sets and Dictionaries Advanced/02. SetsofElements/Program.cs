using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SetsofElements
{
    internal class SetsOfElements
    {
        static void Main(string[] args)
        {
            string[] loopLength = Console.ReadLine().Split(" ").ToArray();
            int firstLoop = int.Parse(loopLength[0]);
            int secondLoop = int.Parse(loopLength[1]);
            HashSet<int> firstNums = new HashSet<int>();
            HashSet<int> secondNums = new HashSet<int>();
            for (int i = 1; i <= firstLoop; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstNums.Add(num);
            }
            for (int i = 1; i <= secondLoop; i++)
            {
                secondNums.Add(int.Parse(Console.ReadLine()));
            }
            firstNums.IntersectWith(secondNums);
            Console.WriteLine(String.Join(" ", firstNums));
        }
    }
}
