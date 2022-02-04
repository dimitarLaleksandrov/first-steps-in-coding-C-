using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            int difference = 0;
            int timeH = 0;
            int timeM = 0;
            minExam += hourExam * 60;
            arrivalMin += arrivalHour * 60;
            if(arrivalMin > minExam)
            {
                Console.WriteLine("Late");
                difference = arrivalMin - minExam;
                if(difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    timeH = difference / 60;
                    timeM = difference % 60;
                    Console.WriteLine($"{timeH}:{timeM:d2} hours after the start");
                }
            }
            else if(arrivalMin < minExam - 30)
            {
                Console.WriteLine("Early");
                difference = minExam - arrivalMin;
                if(difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    timeH = difference / 60;
                    timeM = difference % 60;
                    Console.WriteLine($"{timeH}:{timeM:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = minExam - arrivalMin;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
