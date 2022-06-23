using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public double LandingStrip { get; private set; }

        public List<Drone> Drones { get; set; }

        public int Count { get { return Drones.Count; } }

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name)
                || string.IsNullOrEmpty(drone.Brand)
                || (drone.Range <= 5 && drone.Range >= 15))
            {
                return "Invalid drone.";
            }

            if (Count >= Capacity)
            {
                return "Airfield is full.";
            }

            Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            var removedCount = Drones.RemoveAll(dr => dr.Name == name);
            return removedCount > 0;
        }

        public int RemoveDroneByBrand(string brand)
        {
            return Drones.RemoveAll(dr => dr.Brand == brand);
        }

        public Drone FlyDrone(string name)
        {
            var drone = Drones.FirstOrDefault(drone => drone.Name == name);
            if (drone == null) return null;

            drone.Available = false;
            return drone;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            var dronesToFly = Drones.FindAll(drone => drone.Range >= range);
            foreach (var drone in dronesToFly)
            {
                FlyDrone(drone.Name);
            }
            return dronesToFly;
        }

        public string Report()
        {
            var dronesOnGroung = Drones.FindAll(drone => drone.Available);
            var text = new StringBuilder();
            text.AppendLine($"Drones available at {Name}:");
            foreach (var drone in dronesOnGroung)
            {
                text.AppendLine(drone.ToString());
            }
            return text.ToString();
        }
     }
}
