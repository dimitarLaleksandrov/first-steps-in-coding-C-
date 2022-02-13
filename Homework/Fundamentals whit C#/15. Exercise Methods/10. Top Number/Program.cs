using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            TopNum(input);
        }
        static void TopNum(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (HaveOddDIgit(i) && IsItDivisible(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool  IsItDivisible(int num)
        {
            int divisible = 0;
            while (num > 0)
            {
                divisible += num % 10;
                num /= 10;
            }
            if (divisible % 8 == 0)
            {
                return true; 
            }
            return false;
        }
        static bool HaveOddDIgit(int num)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 == 1)
                {
                    return true;                   
                }
                num /= 10;
            }
            return false;
        }   
    }
}
