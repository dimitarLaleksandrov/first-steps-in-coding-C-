using System;

namespace Exam_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            for (int i = 0; i < locations; i++)
            {
                double averageGoldPerDay = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double averageExtract = 0;
                for (int d = 0; d < days; d++)
                {
                    double extraction = double.Parse(Console.ReadLine());
                    averageExtract += extraction;
                   
                }
                double average = averageExtract / days;
                if (average >= averageGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {average:f2}.");
                }
                else if (average < averageGoldPerDay)
                {
                    Console.WriteLine($"You need {averageGoldPerDay - average:f2} gold.");

                }

            }
        }
    }
}
