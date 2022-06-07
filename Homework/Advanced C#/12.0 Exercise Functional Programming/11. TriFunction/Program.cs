using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    internal class TriFunction
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Console.WriteLine(names.First(name => name.Select(symbol => (int)symbol).Sum() >= num));
        }
    }
}
