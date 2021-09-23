using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int durationEpisot = int.Parse(Console.ReadLine());
            double durationBreak = double.Parse(Console.ReadLine());
            double lunch = durationBreak / 8;
            double rest = durationBreak / 4;
            var otherTime = Math.Floor(durationBreak - lunch - rest);
            if(otherTime >= durationEpisot)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {otherTime - durationEpisot} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {durationEpisot - otherTime} more minutes.");
            }
        }
    }
}
