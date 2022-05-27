using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class PeriodicTable
    {
        static void Main(string[] args)
        {
            int loopNum = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 1; i <= loopNum; i++)
            {
                string[] printElements = Console.ReadLine().Split(" ");
                foreach (string element in printElements)
                {
                    elements.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
