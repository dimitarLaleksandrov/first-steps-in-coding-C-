using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int sumOfEvenDigits = GetEvenNum(num);
            int sumOfOddDigits = GetOddNum(num);
            Console.WriteLine(Math.Abs(sumOfOddDigits * sumOfEvenDigits));
        }
        static int GetEvenNum(int num)
        {
           int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    sum += num % 10;
                }
                num /= 10;
            }
            return sum;
        }
        static int GetOddNum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                if (digit % 2 != 0)
                {
                    sum += num % 10;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
