using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Raw_Data
{
    internal class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int carNumbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= carNumbers; i++)
            {
                string[] car = Console.ReadLine().Split(' ');
                string model = car[0];
                int engineSpeed = int.Parse(car[1]);
                int enginePower = int.Parse(car[2]);
                int cargoWeight = int.Parse(car[3]);
                string cargoType = car[4];
                double tire1Pressure = double.Parse(car[5]);
                int tire1Age = int.Parse(car[6]);
                double tire2Pressure = double.Parse(car[7]);
                int tire2Age = int.Parse(car[8]);
                double tire3Pressure = double.Parse(car[9]);
                int tire3Age = int.Parse(car[10]);
                double tire4Pressure = double.Parse(car[11]);
                int tire4Age = int.Parse(car[12]);
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tires tire1 = new Tires(tire1Age, tire1Pressure);
                Tires tire2 = new Tires(tire2Age, tire2Pressure);
                Tires tire3 = new Tires(tire3Age, tire3Pressure);
                Tires tire4 = new Tires(tire4Age, tire4Pressure);
                List<Tires> tires = new List<Tires>();
                tires.Add(tire1);
                tires.Add(tire2);
                tires.Add(tire3);
                tires.Add(tire4);
                Car carInfo = new Car(model, engine, cargo, tires);
                cars.Add(carInfo);
                 
            }
            string cmd = Console.ReadLine();
            if (cmd == "fragile")
            {
                List<string> fragileCars = new List<string>();
                foreach (var car in cars)
                {
                    if(car.Cargo.Type == cmd)
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                fragileCars.Add(car.Models);
                                break;
                            }
                        }
                    }
                }
                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car);
                }
            }
            else if (cmd == "flammable")
            {
                List<string> flammableCars = new List<string>();
                foreach (var car in cars)
                {
                    if (car.Engine.Power > 250)
                    {
                        flammableCars.Add(car.Models);
                    }
                }
                foreach (var car in flammableCars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
