using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;
        private readonly List<string> items;
        public Planet(string name)
        {
            Name = name;
            items = new List<string>();
        }
        public ICollection<string> Items
        {
            get { return items; }
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"Invalid name!");
                }
                name = value;
            }
        }
    }
}
