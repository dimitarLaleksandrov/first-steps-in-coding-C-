using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double resolt = FirstFactorialNum(firstNum) / SecondFactorialNum(secondNum);
            Console.WriteLine($"{resolt:f2}"); 
        }
        
        static double FirstFactorialNum(int firstNum)
        {
            double factorialFurstNum = 1;
            for (int i = firstNum; i > 0; i--)
            {
                factorialFurstNum *= i;
            }
            return factorialFurstNum;
        }
        static double SecondFactorialNum(int secondNum)
        {
            double factorialSecondNum = 1;

            for (int i = secondNum; i > 0; i--)
            {
                factorialSecondNum *= i;
            }
            return factorialSecondNum;
        }
    }
}
