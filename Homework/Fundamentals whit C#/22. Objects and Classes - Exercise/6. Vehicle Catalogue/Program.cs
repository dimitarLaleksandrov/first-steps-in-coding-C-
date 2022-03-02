using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    internal class Program
    {
        class Truck
        {
            public Truck(string brand, string model, string color, int horsePower)
            {
                this.HorsePower = horsePower;
                this.Brand = brand;
                this.Model = model;
                this.Color = color;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
        class Car
        {
            public Car(string brand, string model, string color, int horsePower)
            {
                this.Brand = brand;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower; 
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
            public string Color { get; set; }
        }
        class Catalog
        {
            public Catalog()
            {
                this.Trucks = new List<Truck>();
                this.Cars = new List<Car>();
            }
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
        static void Main(string[] args)
        {
            string[] splitParams = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Catalog catalogObject = new Catalog();
            while (splitParams[0] != "End")
            {
                
                string type = splitParams[0];
                string brand = splitParams[1];
                string color = splitParams[2];
                int horsePower = int.Parse(splitParams[3]);
                if (type == "car")
                {
                    Car newCar = new Car(type, brand, color, horsePower);
                    catalogObject.Cars.Add(newCar);
                }
                else if (type == "truck")
                {
                    Truck newTruck = new Truck(type, brand, color, horsePower);
                    catalogObject.Trucks.Add(newTruck);
                }
                splitParams = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            string brandOfMashin = Console.ReadLine().Trim();
            if (brandOfMashin == )
            {
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
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.HorsePower}");
                }
            }
        }
    }
}
