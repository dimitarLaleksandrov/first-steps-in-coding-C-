using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops= int.Parse(Console.ReadLine());
            int number = 0;
            int digitNum = 0;
            bool flag = false;
            for (int i = 1; i <= loops; i++)
            {
                digitNum = i;
                while (i > 0)
                {
                    number += i % 10;
                    i /= 10;
                }
                flag = (number == 5) || (number == 7) || (number == 11);
                Console.WriteLine($"{digitNum} -> {flag}");
                number = 0;
                i = digitNum;
            }
        }
    }
}
