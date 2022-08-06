using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int capasity;
        private int comfort;
        private ICollection<IDecoration> decorations;
        private ICollection<IFish> fish;
        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Decorations = new HashSet<IDecoration>();
            this.Fish = new HashSet<IFish>();
        }
        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Capacity
        {
            get { return this.capasity; }
            protected set { this.capasity = value; }
        }

        public int Comfort
        {
            get { return this.comfort; }
            protected set
            {
                this.Decorations.Sum(d => d.Comfort);
            }
        }

        public ICollection<IDecoration> Decorations
        {
            get { return this.decorations; }
            protected set { this.decorations = value; }
        }

        public ICollection<IFish> Fish
        {
            get { return this.fish; }
            protected set
            {
                this.fish = value;
            }
        }

        public void AddDecoration(IDecoration decoration)
        {
            this.Decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (this.Fish.Count + 1 > this.Capacity)
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
            this.Fish.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in this.Fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            var sb = new StringBuilder();
            string fistOutput = this.Fish.Count > 0 ? string.Join(", ", this.Fish.Select(f => f.Name)) : "none";
            sb.AppendLine($"{this.Name} ({this.GetType().Name}):");
            sb.AppendLine($"Fish: {fistOutput}");
            sb.AppendLine($"Decorations: {this.Decorations.Count()}");
            sb.AppendLine($"Comfort: {this.Comfort}");
            return sb.ToString();
        }
        public bool RemoveFish(IFish fish) => this.Fish.Remove(fish);
    }
}
