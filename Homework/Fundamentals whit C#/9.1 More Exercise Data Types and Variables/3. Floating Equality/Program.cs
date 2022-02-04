using System;

namespace _3._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double eps = 0.000001d;
            bool isTrue = (Math.Abs(numOne - numTwo) <= eps);
            //Boolean isTrue = (Math.Abs(numOne - numTwo) <= eps);
            if (isTrue)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
