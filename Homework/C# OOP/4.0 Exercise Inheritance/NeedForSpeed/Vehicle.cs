using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        private double defaultfuelconsumption;
        private double fuelconsumption;
        private double fuel;
        private int horsepower;
        public double Defaultfuelconsumption
        {
            get { return defaultfuelconsumption; }
            set { defaultfuelconsumption = 1.25; }
        }
        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        public virtual double FuelConsumption
        {
            get { return fuelconsumption; }
            set
            {
                fuelconsumption = value;
            }
        }
        public int HorsePower
        {
            get { return horsepower; }
            set
            {
                horsepower = value;
            }
        }
        public virtual void Drive(double kilometers)
        {
            double fuelConsume = 0;
            if(FuelConsumption == double.NaN)
            {
                fuelConsume = Defaultfuelconsumption * kilometers;
            }
            else
            {
                fuelConsume = FuelConsumption * kilometers;
            }
            Fuel -= fuelConsume;
        }
    }
}
