using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double TruckIncreasedConsumaption = 1.6;
        private const double RefuelCoeffiecient = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + TruckIncreasedConsumaption)
        {

        }
        public override void Refuel(double liters)
        {
            base.Refuel(liters * RefuelCoeffiecient);
        }
    }
}
