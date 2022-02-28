using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Weight = weight;
            this.Brand = brand;
            this.Model = model;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand=brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
       //wen we got properties  coz public List<Car or Truks> = null; - defolt;
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Catalog catalogObject = new Catalog();
            while (command != "end")
            {
                string[] splitParams = command.Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = splitParams[0];
                string brand = splitParams[1];
                string model = splitParams[2];
                int finalparam = int.Parse(splitParams[3]);
                if (type == "Car")
                {
                    Car newCar = new Car( brand, model, finalparam);
                    catalogObject.Cars.Add(newCar);
                }
                else if (type == "Truck")
                {
                    Truck newTruck = new Truck( brand, model, finalparam);
                    catalogObject.Trucks.Add(newTruck);
                }
                command = Console.ReadLine();
            }
            if (catalogObject.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                List<Car> orderetCars = catalogObject.Cars.OrderBy(car => car.Brand).ToList();
                foreach (Car car in orderetCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogObject.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                List<Truck> orderetTrucks = catalogObject.Trucks.OrderBy(truck => truck.Brand).ToList();
                foreach (Truck truck in orderetTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }           
        }
    }
}
