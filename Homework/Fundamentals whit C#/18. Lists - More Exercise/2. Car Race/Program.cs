using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Car_Race
{
    internal class Program
    {
        public static object Lis { get; private set; }

        static void Main(string[] args)
        {
            List<int> carRace = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int finishLIne = carRace.Count / 2;
            double firsCar = 0;
            double secondCar = 0;
            for (int i = 0; i < finishLIne ; i++)
            {
                firsCar += carRace[i];
                if (carRace[i] == 0)
                {
                    firsCar *= 0.8;
                }              
            }
            for (int i = carRace.Count - 1; i > finishLIne; i--)
            {
                secondCar += carRace[i];
                if (carRace[i] == 0)
                {
                    secondCar *= 0.8;
                }
            }       

            if (firsCar < secondCar)
            {
                Console.WriteLine($"The winner is left with total time: {firsCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondCar}");
            }          
        }
    }
}
