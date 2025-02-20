using System.Text;

namespace EXAM_TASK_3
{
    internal class Program
    {
        public class Drone
        {
            public Drone(string name, string brand, int range)
            {
                Name = name;
                Brand = brand;
                Range = range;
                Available = true;
            }

            public string Name { get; private set; }
            public string Brand { get; private set; }

            public int Range { get; private set; }

            public bool Available { get; set; }

            public override string ToString()
            {
                var text = new StringBuilder();
                text.AppendLine($"Drone: {Name}");
                text.AppendLine($"Manufactured by: {Brand}");
                text.AppendLine($"Range: {Range} kilometers");
                return text.ToString();
            }
        }

        public class Airfield
        {
            public Airfield(string name, int capacity, double landingStrip)
            {
                Name = name;
                Capacity = capacity;
                LandingStrip = landingStrip;
                this.Drones = new List<Drone>();
            }

            public string Name { get; set; }
            public int Capacity { get; set; }
            public double LandingStrip { get; set; }

            public List<Drone> Drones { get; set; }

            public int Count { get { return Drones.Count; } }

            public string AddDrone(Drone drone)
            {
                if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || (drone.Range <= 5 && drone.Range >= 15))
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
                if (drone == null) 
                {
                    return null;
                }
  
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

        static void Main(string[] args)
        {

            Airfield airfield = new Airfield("Heathrow", 10, 10.5);
            Drone drone = new Drone("D20", "DEERC", 6);

            Console.WriteLine(drone);
        
            Console.WriteLine(airfield.AddDrone(drone));

            Console.WriteLine(airfield.Count);

            Console.WriteLine(airfield.RemoveDrone("DE51"));

            Drone secondDrone = new Drone("CW4", "Cheerwing", 8);
            Drone thirdDrone = new Drone("X5SW-V3", "Cheerwing", 7);
            Drone fourthDrone = new Drone("X20", "Cheerwing", 4);
            Drone fifthDrone = new Drone("EVO2", "Autel", 10);
            Drone sixtDrone = new Drone("XL5-6S-FPV", "iFlight", 10);

            Console.WriteLine(airfield.AddDrone(secondDrone));

            Console.WriteLine(airfield.AddDrone(thirdDrone));
            
            Console.WriteLine(airfield.AddDrone(fourthDrone));
           
            Console.WriteLine(airfield.AddDrone(fifthDrone));
            
            Console.WriteLine(airfield.AddDrone(sixtDrone));
              
            Console.WriteLine(airfield.FlyDrone("CW4"));
            
            Console.WriteLine("-----------------FlyDronesByRange-----------------");
            List<Drone> flyDrones = airfield.FlyDronesByRange(10);

            foreach (var droneToFly in flyDrones)
            {
                Console.WriteLine(droneToFly);
            }
           
            Console.WriteLine(airfield.RemoveDroneByBrand("Cheerwing"));
           

            Console.WriteLine("----------------------Report----------------------");
            Console.WriteLine(airfield.Report());
           
        }

    }
}
