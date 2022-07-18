using System;

namespace  Vehicles
{
    using Factorise.Interfaces;
    using Models;
    using Factorise;
    using Core;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IVehiclefactory vehicleFactory = new Vehiclefactory();
            string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] truckData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = vehicleFactory.CreateVehicle(carData[0], double.Parse(carData[1]), double.Parse(carData[2]));
            Vehicle truck = vehicleFactory.CreateVehicle(truckData[0], double.Parse(truckData[1]), double.Parse(truckData[2]));
            IEngine engine = new Engen(car, truck);
            engine.Start();
        }
    }
}
