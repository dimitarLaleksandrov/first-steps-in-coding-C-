using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Cars = new List<Car>(capacity);
        }
        List<Car> cars;
        private string type;
        private int capacity;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public List<Car> Cars
        {
            get { return cars; }
            set
            {
                cars = value;
            }
        }
        public void Add(Car car)
        {
            if(cars.Count < capacity)
            {
                cars.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            bool isTheCarRemoved = false;
            var car = cars.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
            if (cars.Contains(car))
            {
                cars.Remove(car);
                isTheCarRemoved = true;
            }
            
            return isTheCarRemoved;
        }
        public Car GetLatestCar()
        {
            Car latestCar = cars.FirstOrDefault(c => c.Year == c.Year);
            foreach (var car in cars)
            {
                if(car.Year > latestCar.Year)
                {
                    latestCar = car;
                }
            }
            return latestCar;
        }
        public Car GetCar(string manufacturer, string model)
        {
            Car getCar = cars.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
            return getCar;
        }
        public int Count { get { return cars.Count; } }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            sb.AppendLine($"{string.Join(Environment.NewLine, cars)}");
            return sb.ToString();
        }
    }
}
