using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    internal class SpeedRacing
    {
        static void Main(string[] args)
        {
            int carNumber = int.Parse(Console.ReadLine());
            List<Cars> cars = new List<Cars>();
            for (int i = 1; i <= carNumber; i++)
            {
                string[] car = Console.ReadLine().Split();
                string model = car[0];
                double fuelAmount = double.Parse(car[1]);
                double fuelConsumptionFor1km = double.Parse(car[2]);
                double travelDistance = 0;
                Cars carInfo = new Cars(model, fuelAmount, fuelConsumptionFor1km, travelDistance);
                cars.Add(carInfo);
            }
            string cmd = string.Empty;
            while((cmd = Console.ReadLine()) != "End")
            {
                string command = cmd.Split()[0];
                string carModel = cmd.Split()[1];
                double amountOfKm = double.Parse(cmd.Split()[2]);
                Cars carToDrive = cars.First(car => car.Model == carModel);
                carToDrive.Drive(amountOfKm);

            }
            foreach (Cars car in cars) // var
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
