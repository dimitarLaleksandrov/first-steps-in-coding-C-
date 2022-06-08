using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    public class Cargo
    {
        public Cargo(string type, int weigth)
        {
            Type = type;
            Weight = weigth;
        }
        private string type;
        private int weight;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
