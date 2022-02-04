using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digitNum = 0;
            int sum = 0;
            while (num != 0)
            {
                digitNum = num % 10;
                sum += digitNum;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
