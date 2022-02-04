using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;
            var number = "";
            for (int i = startNum; i <= endNum; i++)
            {
                number += i + " ";
                sum += i;
            }
            Console.WriteLine(number);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
