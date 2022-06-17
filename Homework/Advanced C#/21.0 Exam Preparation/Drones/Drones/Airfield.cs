using System;
using System.Collections.Generic;
using System.Linq;

namespace Drones
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
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public int Count => this.Drones.Count(d => d.Available);
        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }
            if (this.Capacity <= Drones.Count)
            {
                return "Airfield is full.";
            }
            this.Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }
        public bool RemoveDrone(string name)
        {
            //int count = this.Drones.RemoveAll(dr => dr.Name == name);
            //return count > 0;
            bool found = false;
            var picketDrons = new List<Drone>();
            foreach (var dron in picketDrons)
            {
                if(dron.Name != name)
                {
                    picketDrons.Add(dron);
                    found = true;
                }
            }
            this.Drones = picketDrons;
            return found;
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = this.Drones.RemoveAll(dr => dr.Brand == brand);
            return count;
        }
        public Drone FlyDrone(string name)
        {
            Drone drone = this.Drones.FirstOrDefault(dr => dr.Name == name);
            if(drone == null)
            {
                return null;
            }
           drone.Available = false;
           return drone;
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = this.Drones.Where(dr => dr.Range >= range).ToList();
            foreach (var dr in drones)
            {
                dr.Available = false;
            }
            return drones;
        }
        public string Report()
        {
            var availableDrons = this.Drones.Where(dr => dr.Available).ToList();
            return $"Drones available at {this.Name}:" + Environment.NewLine +
                    string.Join(Environment.NewLine, availableDrons);
        }
    }
}
