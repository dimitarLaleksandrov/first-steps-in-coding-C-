using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int curentNum = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int k = 1; k <= i ; k++)
                {
                    if (curentNum > num)
                    {
                        continue;
                    }
                    Console.Write($"{curentNum} ");
                    curentNum++;
                }
                Console.WriteLine();
            }
        }
    }
}
