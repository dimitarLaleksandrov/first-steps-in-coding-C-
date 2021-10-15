using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            while (sum < num)
            {
                int infinitiNum = int.Parse(Console.ReadLine());
                sum += infinitiNum;
            }
            Console.WriteLine(sum);
        }
    }
}
