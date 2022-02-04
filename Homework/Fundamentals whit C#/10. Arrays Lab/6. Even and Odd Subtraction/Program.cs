using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            foreach (int item in num)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }
                else
                {
                    oddSum += item;
                }
            }
            int difarenc = evenSum - oddSum;
            Console.WriteLine(difarenc);
        }
    }
}
