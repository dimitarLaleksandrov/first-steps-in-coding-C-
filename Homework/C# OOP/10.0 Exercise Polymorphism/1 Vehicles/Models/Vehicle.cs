using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    using Interfaces;
    public class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            private set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            protected set { this.fuelConsumption = value; }
        }

        public string Drive(double distance)
        {
            double fuilNeedet = distance * this.FuelConsumption;
            if (fuilNeedet > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            this.FuelQuantity -= fuilNeedet;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
