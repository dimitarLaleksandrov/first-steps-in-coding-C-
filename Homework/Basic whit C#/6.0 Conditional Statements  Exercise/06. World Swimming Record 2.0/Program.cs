using System;

namespace _06._World_Swimming_Record_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distenc = double.Parse(Console.ReadLine());
            double timeForOneSec = double.Parse(Console.ReadLine());
            double timePluse = Math.Floor(distenc / 15);
            double addTime = timePluse * 12.5;
            double swim = timeForOneSec * distenc;
            double ivanTime = swim + addTime;
            if(record > ivanTime)
             {
                 Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
             }
             if(record <= ivanTime)
             {
                Console.WriteLine($"No, he failed! He was {ivanTime - record:f2} seconds slower.");
             }

        }
    }
}
