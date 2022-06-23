using System;
using System.Text;

namespace _3._2_Drones
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
}
