using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    internal class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
        private int speed;
        private int power;
        public int Speed 
        { 
            get { return speed; } 
            set { speed = value; } 
        }
        public int Power
        { 
            get { return power; } 
            set { power = value; } 
        }
    }
}
