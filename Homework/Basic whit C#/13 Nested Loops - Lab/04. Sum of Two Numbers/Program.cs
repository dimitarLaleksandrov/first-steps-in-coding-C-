using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int all = 0;
            int combination = 0;
            for (int start = startInterval; start <= endInterval ; start++)
            {
                for (int end = startInterval; end <= endInterval ; end++)
                {
                    all = start + end;
                    combination++;
                    if (all == num)
                    {
                        Console.WriteLine($"Combination N:{combination} ({start} + {end} = {num})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combination} combinations - neither equals {num}");
        }
    }
}
