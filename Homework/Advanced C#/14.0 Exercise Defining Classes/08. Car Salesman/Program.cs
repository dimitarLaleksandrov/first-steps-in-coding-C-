using System;
using System.Collections.Generic;
using System.Globalization;

namespace _08._Car_Salesman
{
    internal class CarSalesman
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            int enginesNums = int.Parse(Console.ReadLine());
            for (int i = 1; i <= enginesNums; i++)
            {
                string[] engineInfo = Console.ReadLine().Split();
                if (engineInfo.Length == 4)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
                else if (engineInfo.Length == 3)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    int displacement = int.Parse(engineInfo[2]);
                    engines.Add(new Engine(model, power, displacement));
                }
                else if (engineInfo.Length == 2)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    engines.Add(new Engine(model, power));
                }             
            }
            int carsNum = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 1; i <= carsNum; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                if (carInfo.Length == 2)
                {
                    string model = carInfo[0];
                    string engenModel = carInfo[1];
                    foreach (var engen in engines)
                    {
                        if (engen.Model == engenModel)
                        {
                            cars.Add(new Car(model, engen));
                        }
                    }
                }
                else if(carInfo.Length == 3)
                {
                    string model = carInfo[0];
                    string engenModel = carInfo[1];
                    string n = int.TryParse(carInfo[2]);
                    char[] chars = n.ToCharArray();
                    if (n = int.TryParse(n)
                    {

                    }
                    int weight = int.Parse();
                    foreach (var engen in engines)
                    {
                        if (engen.Model == engenModel)
                        {
                            cars.Add(new Car(model, engen, weight));
                        }
                    }
                }
                else if (carInfo.Length == 4)
                {
                    string model = carInfo[0];
                    string engenModel = carInfo[1];
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    foreach (var engen in engines)
                    {
                        if (engen.Model == engenModel)
                        {
                            cars.Add(new Car(model, engen, weight, color));
                        }
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}");
                if (car.Engine.Displacement != 0)
                {
                    if (car.Engine.Efficiency != null)
                    {
                        Console.WriteLine($"    Power: {car.Engine.Power}");
                        Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                        Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                    }
                    else
                    {
                        Console.WriteLine($"    Power: {car.Engine.Power}");
                        Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                        Console.WriteLine($"    Efficiency: n/a");
                    }
                }
                else
                {
                    Console.WriteLine($"    Power: {car.Engine.Power}");
                    Console.WriteLine($"    Displacement: n/a");
                    Console.WriteLine($"    Efficiency: n/a");
                }
                if (car.Weight != 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                if (car.Color != null)
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($"  Color: n/a");
                }
            }
        }
    }
}
