using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(n =>int.Parse(n)).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
            
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
