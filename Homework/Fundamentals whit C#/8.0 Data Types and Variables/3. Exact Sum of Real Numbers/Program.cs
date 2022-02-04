using System;

namespace _3._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPoint = int.Parse(Console.ReadLine());
            decimal numCounter = 0;
            for (int i =1; i <= numberPoint; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                numCounter += num;
            }
            Console.WriteLine(numCounter);
        }
    }
}
