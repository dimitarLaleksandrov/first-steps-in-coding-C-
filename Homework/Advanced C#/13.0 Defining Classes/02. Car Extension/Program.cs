using System;

namespace _02._Car_Extension
{
    internal class CarExtension
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            cars.Make = "VW";
            cars.Model = "MK3";
            cars.Year = 1993;
            cars.FuelQuantity = 200;
            cars.FuelConsumption = 200;
            cars.Drive(2000);
            Console.WriteLine(cars.WhoAmI());
        }
    }
}
