using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int addMin = min + 15;
            if(addMin >= 60)
            {
                addMin -= 60;
                hours += 1;
            }
            if(hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{addMin:d2}");
        }
    }
}
