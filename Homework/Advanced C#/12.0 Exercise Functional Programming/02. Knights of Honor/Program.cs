using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class KnightsofHonor
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ").ToList();
            Action<string> printName = name => Console.WriteLine($"Sir {name}");
            names.ForEach(printName);
        }
    }
}
