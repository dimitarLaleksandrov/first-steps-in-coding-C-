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
            if (distance >= 15)
            {
               var plusFiftine = Math.Floor(distance / 15.0);
               var addTime = plusFiftine * 12.5;
               var time = distance * timeForOneMeter;
               var allTime = time + addTime;
                if(theRecord > allTime)
                {
                    Console.WriteLine($"Yes, he succeeded! The new world record is {allTime:f2} seconds.");
                }
                else if(theRecord < allTime)
                {
                    Console.WriteLine($"No, he failed! He was {allTime - theRecord:f2} seconds slower.");
                }
            }
        }
    }
}
