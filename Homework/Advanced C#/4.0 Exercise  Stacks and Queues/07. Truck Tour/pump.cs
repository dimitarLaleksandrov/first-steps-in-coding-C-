using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Truck_Tour
{
    internal class Pump
    {
        private int number;
        private int amount;
        private int distance;
        public Pump(int number, int amaunt, int distance)
        {
            Number = number;
            Amaunt = amaunt;
            Distance = distance;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Amaunt
        {
            get { return amount; }
            set { amount = value; }
        }
        public int Distance
        {
            get { return distance; }
            set { distance = value; } 
        }
    }
}
