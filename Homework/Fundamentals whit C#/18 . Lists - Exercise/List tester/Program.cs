using System;
using System.Collections.Generic;
using System.Linq;

namespace List_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, numbers[numbers.Count - 1]);

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
