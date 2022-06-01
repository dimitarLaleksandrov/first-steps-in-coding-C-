using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }
    }
}
