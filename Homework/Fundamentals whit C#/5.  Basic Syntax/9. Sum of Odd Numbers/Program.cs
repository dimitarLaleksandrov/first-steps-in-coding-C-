using System;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < input ; i++)
            {
                Console.WriteLine(1 + (i * 2));
                sum += 1 + (i * 2);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
