using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += num;
                }
                else if (i % 2 == 1)
                {
                    odd += num;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                int diff = Math.Abs(even - odd);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
