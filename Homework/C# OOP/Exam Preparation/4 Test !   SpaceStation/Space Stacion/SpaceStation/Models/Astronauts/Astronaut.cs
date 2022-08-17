using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Models.Bags.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;
        private bool canBreath;
        private IBag bag;
        public Astronaut(string name, double oxygen)
        {
            Name = name;
            Oxygen = oxygen;
            Bag = new Backpack();
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"Astronaut name cannot be null or empty.");
                }
                name = value;
            }
        }

        public double Oxygen
        {
            get { return oxygen; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Cannot create Astronaut with negative oxygen!");
                }
            }
        }

        public bool CanBreath
        {
            get { return canBreath; }
            private set 
            {
                if (Oxygen > 0)
                {
                    value = true;
                }
                else
                {
                    value = false;
                } 
                canBreath = value; 
            }
        }

        public IBag Bag
        {
            get { return bag; }
            private set => bag = value;
        }

        public virtual void Breath()
        {
            Oxygen -= 10;
        }  
    }
}
