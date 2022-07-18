using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Factorise
{
    using Interfaces;
    using Vehicles.Models;

    public class Vehiclefactory : IVehiclefactory
    {
        public Vehicle CreateVehicle(string vehicleTipe, double fuleQuontity, double fuileConsumpshion)
        {
            Vehicle vehicle;
            if(vehicleTipe == "Car")
            {
                vehicle = new Car(fuleQuontity, fuileConsumpshion);
            }
            else if (vehicleTipe == "Truck")
            {
                vehicle = new Truck(fuleQuontity, fuileConsumpshion);
            }
            else
            {
                throw new InvalidOperationException("Invalid vehicle tipe!");
            }
            return vehicle;
        }
    }
}
