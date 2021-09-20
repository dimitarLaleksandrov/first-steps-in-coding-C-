using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double theRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());
            double ivanSwime = distance * timeForOneMeter;
            if(distance >= 15)
            {
                distance = distance / 15;
            }
            double addTime = distance * 12.5;
            double allTime = ivanSwime + addTime;
            double timeNeed = Math.Abs(allTime - theRecord);
            if(theRecord < allTime)
            {
                Console.WriteLine($"No, he failed! he was {timeNeed:f2} seconds slower.");
            }
            else if(theRecord > allTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new worl {allTime:f2} seconds.");
            }
        }
    }
}
