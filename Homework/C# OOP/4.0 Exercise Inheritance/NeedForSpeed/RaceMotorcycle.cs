using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DefaultFuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel, double defaultFuelConsumption) : base(horsePower, fuel)
        {
            defaultFuelConsumption = DefaultFuelConsumption;
        }
    }
}
