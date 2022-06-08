using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    internal class Tires
    {
        public Tires(int age, double pressure)
        {
            Age = age;
            Pressure = pressure;
        }
        private int age;
        private double pressure;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
    }
}
