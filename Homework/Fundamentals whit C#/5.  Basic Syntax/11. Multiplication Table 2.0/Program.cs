using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            if (numTwo <= 10)
            {
                for (int i = numTwo; i <= 10; i++)
                {
                    int sum = numOne * i;
                    Console.WriteLine($"{numOne} X {i} = {sum}");
                }
            }
            else
            {
                Console.WriteLine($"{numOne} X {numTwo} = {numOne * numTwo}");
            }
        }
    }
}
