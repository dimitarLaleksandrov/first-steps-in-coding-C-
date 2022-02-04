using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopNum = int.Parse(Console.ReadLine());
            int[] numbers = new int[loopNum];
            for (int i = 0; i < loopNum; i++)
            {
                int tipedNumber = int.Parse(Console.ReadLine());
                numbers[i] = tipedNumber;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
