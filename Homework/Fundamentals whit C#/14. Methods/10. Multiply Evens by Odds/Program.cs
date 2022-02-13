using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int num = Math.Abs(int.Parse(Console.ReadLine()));
        //    int sumOfEvenDigits = GetEvenNum(num);
        //    int sumOfOddDigits = GetOddNum(num);
        //    Console.WriteLine(Math.Abs(sumOfOddDigits * sumOfEvenDigits));
        //}
        //static int GetEvenNum(int num)
        //{
        //   int sum = 0;
        //    while (num != 0)
        //    {
        //        int digit = num % 10;
        //        if (digit % 2 == 0)
        //        {
        //            sum += num % 10;
        //        }
        //        num /= 10;
        //    }
        //    return sum;
        //}
        //static int GetOddNum(int num)
        //{
        //    int sum = 0;
        //    while (num != 0)
        //    {
        //        int digit = num % 10;
        //        if (digit % 2 != 0)
        //        {
        //            sum += num % 10;
        //        }
        //        num /= 10;
        //    }
        //    return sum;
        //}
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int sumOfEvenDigits = 0;
            int sumOfOddDigits = 0;

            if (int.Parse(input) < 0)
            {
                input = input.Substring(1);
            }

            for (int i = 0; i < input.Length; i++)
            {
                string charecter = input[i].ToString();
                var number = int.Parse(charecter);
                if (IsOddNumber(number))
                {
                    sumOfOddDigits += number;
                }

                if (IsEvenNumber(number))
                {
                    sumOfEvenDigits += number;
                }
            }
            
            Console.WriteLine(Math.Abs(sumOfOddDigits * sumOfEvenDigits));
        }

        static bool IsOddNumber(int num)
        {
            return num % 2 != 0;
        }

        static bool IsEvenNumber(int num)
        {
            return num % 2 == 0;
        }

    }
}
