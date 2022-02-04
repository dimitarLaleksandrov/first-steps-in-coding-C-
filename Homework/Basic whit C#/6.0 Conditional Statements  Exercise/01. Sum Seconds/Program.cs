using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            int totalTime = time1 + time2 + time3;
            int sec = 0;
            int min = 0;
            if (totalTime >= 120)
            {
                min = 2;
                sec = totalTime - 120;
            }
            else if(totalTime >= 60)
            {
                min = 1;
                sec = totalTime - 60;
            }
            else
            {
                sec = totalTime;
            }
            Console.WriteLine($"{min}:{sec:d2}");
        }
    }
}
