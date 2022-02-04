using System;

namespace _5._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                int numperInProcess = i;
                int sum = 0;
                while (numperInProcess != 0)
                {
                    int digit = numperInProcess % 10;
                    numperInProcess = numperInProcess / 10;
                    sum += digit;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
