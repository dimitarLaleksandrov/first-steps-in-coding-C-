using System;
using System.Linq;

namespace CustomLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, int> sortFunc =  (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1 : (x % 2 != 0 && y % 2 == 0) ? 1 : x > y ? 1 : x < y  ? -1 : 0;
            Array.Sort(nums,(x, y) => sortFunc(x, y));
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
