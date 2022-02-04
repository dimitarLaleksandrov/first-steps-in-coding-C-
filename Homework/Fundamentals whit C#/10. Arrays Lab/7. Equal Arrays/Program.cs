using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arratsTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool flag = false;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                sum += arrayOne[i];
                if (arrayOne[i] != arratsTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    flag = true;
                    break;
                    //  flag  == continue
                }
            }
            if (!flag)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
