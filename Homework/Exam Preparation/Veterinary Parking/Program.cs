using System;

namespace Veterinary_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int hower = int.Parse(Console.ReadLine());
            decimal allRate = 0;
            decimal parkingRateForTheDay = 0;
            for (int d = 1; d <= day; d++)
            {
                decimal parkingRate = 0;
                for (int h = 1; h <= hower; h++)
                {
                    if (d % 2 == 0)
                    {
                        if (h % 2 == 1)
                        {
                            parkingRateForTheDay = 2.50m;
                        }
                        else
                        {
                            parkingRateForTheDay = 1m;
                        }
                    }
                    else if (d % 2 == 1)
                    {
                        if (h % 2 == 0)
                        {
                            parkingRateForTheDay = 1.25m;
                        }
                        else
                        {
                            parkingRateForTheDay = 1m;
                        }
                    }
                    parkingRate += parkingRateForTheDay;
                }
                allRate += parkingRate;
                Console.WriteLine($"Day: {d} - {parkingRate:f2} leva");
            }
            Console.WriteLine($"Total: {allRate:f2} leva");
        }
    }
}
