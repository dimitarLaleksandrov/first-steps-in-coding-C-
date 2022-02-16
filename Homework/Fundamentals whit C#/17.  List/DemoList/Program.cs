using System;
using System.Collections.Generic;

namespace DemoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 4, 5, 8 };
            Console.WriteLine(list.Count);
            list.Insert(3, 42);
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
