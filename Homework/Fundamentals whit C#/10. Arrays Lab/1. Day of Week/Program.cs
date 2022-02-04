using System;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] nameOfTheDay = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            if (day >= 1 && day <= nameOfTheDay.Length)
            {
                Console.WriteLine(nameOfTheDay[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
