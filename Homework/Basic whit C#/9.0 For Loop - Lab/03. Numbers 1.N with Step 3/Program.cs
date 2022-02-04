using System;

namespace _03._Numbers_1.N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int newNum = 2;
            for (int i = 0; i <= num; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
