using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    internal class Car
    {
        public Car(string model, Engine engine, Cargo cargo, List<Tires> tires)
        {
            Models = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tires> tires;
        public string Models
        {
            get { return model; }
            set { model = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set
            {
                engine = value;
            }
        }
        public Cargo Cargo
        {
            get { return cargo; }
            set
            {
                cargo = value;
            }
        }
        public List<Tires> Tires
        {
            get { return tires; }
            set
            {
                tires = value;
            }
        }
    }
}
