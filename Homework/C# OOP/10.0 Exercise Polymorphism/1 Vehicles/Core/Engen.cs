using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models;

namespace Vehicles.Core
{

    public class Engen : IEngine
    {
        private readonly Vehicle car;
        private readonly Vehicle truck;
        public Engen(Vehicle car, Vehicle truck)
        {
            this.car = car;
            this.truck = truck;
        }
        public void Start()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                string cmdTipe = cmd[0];
                string vehicleTipe = cmd[1];
                double cmdParam = double.Parse(cmd[2]);
                if (cmdTipe == "Drive")
                {
                    if (vehicleTipe == "Car")
                    {
                        Console.WriteLine(this.car.Drive(cmdParam));
                    }
                    else if (vehicleTipe == "Truck")
                    {
                        Console.WriteLine(this.truck.Drive(cmdParam));
                    }
                }
                else if(cmdTipe == "Refuel")
                {
                    if (vehicleTipe == "Car")
                    {
                        this.car.Refuel(cmdParam);
                    }
                    else if (vehicleTipe == "Truck")
                    {
                        this.truck.Refuel(cmdParam);
                    }
                }
            }
            Console.WriteLine(this.car);
            Console.WriteLine(this.truck);
        }
    }
}
