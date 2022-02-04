using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                int rightSide = 0; ;
                int leftSide = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSide += array[j];
                }
                for (int k = array.Length - 1; k > i; k--)
                {
                    rightSide += array[k];
                }
                if (rightSide == leftSide && !flag)
                {
                    Console.WriteLine(i);
                    flag = true;
                }
                else if (leftSide == 0 && rightSide == 0)
                {
                    Console.WriteLine("0");
                }
            }
            if (!flag && array[0] != array[array.Length - 1])
            {
                Console.WriteLine("no");
            }
        }
    }
}
