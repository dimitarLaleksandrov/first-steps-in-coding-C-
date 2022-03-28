using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Need_for_Speed_III
{
    internal class Program
    {
        class Cars
        {
            public Cars (string Model, int Mileage, int Fuel)
            {
                this.Model = Model;
                this.Mileage = Mileage;
                this.Fuel = Fuel;
            }
            public string Model { get; set; }
            public int Mileage { get; set; }
            public int Fuel { get; set; }
        } 
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Cars> car = new Dictionary<string, Cars>();
            for (int i = 1; i <= numberOfCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = carsInfo[0];
                int mileage = int.Parse(carsInfo[1]);
                int fuel = int.Parse(carsInfo[2]);
                Cars newCar = new Cars(model, mileage, fuel);
                car.Add(model, newCar);
            }
            string[] commands = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commands[0] != "Stop")
            {
                if (commands[0] == "Drive")
                {
                    const int maxMileage = 100000;
                    string carName = commands[1];
                    int distance = int.Parse(commands[2]);
                    int fuel = int.Parse(commands[3]);
                    if (car.ContainsKey(carName))
                    {
                        if (car[carName].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else if (car[carName].Mileage < maxMileage)
                        {
                            car[carName].Mileage += distance;
                            car[carName].Fuel -= fuel;
                            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        if (car[carName].Mileage >= maxMileage)
                        {
                            Console.WriteLine($"Time to sell the {carName}!");
                            car.Remove(carName);
                        } 
                    }
                }
                else if (commands[0] == "Refuel")
                {
                    const int maxTankContains = 75;
                    
                    string carName = commands[1];
                    int fuel = int.Parse(commands[2]);
                    int tankFiled = fuel;
                    car[carName].Fuel += fuel;
                    if (car[carName].Fuel > maxTankContains)
                    {
                        tankFiled = car[carName].Fuel - maxTankContains;
                        car[carName].Fuel = maxTankContains;
                    }
                    Console.WriteLine($"{carName} refueled with {tankFiled} liters");

                }
                else if (commands[0] == "Revert")
                {
                    const int mindecreaseing = 10000;
                    string carName = commands[1];
                    int decreaseKilomether = int.Parse(commands[2]);
                    car[carName].Mileage -= decreaseKilomether;
                    if (car[carName].Mileage < mindecreaseing)
                    {
                        car[carName].Mileage = mindecreaseing;
                        commands = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    Console.WriteLine($"{carName} mileage decreased by {decreaseKilomether} kilometers");
                }
                commands = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var machine in car)
            {
                Console.WriteLine($"{machine.Key} -> Mileage: {machine.Value.Mileage} kms, Fuel in the tank: {machine.Value.Fuel} lt.");
            }
        }
    }
}
