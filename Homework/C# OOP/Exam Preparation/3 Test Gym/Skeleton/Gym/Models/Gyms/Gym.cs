using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private readonly List<IEquipment> equipment;
        private readonly List<IAthlete> athletes;
        protected Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            equipment = new List<IEquipment>();
            athletes = new List<IAthlete>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }
                name = value;
            }
        }
        public int Capacity { get; private set; }
        public double EquipmentWeight
        {
            get
            {
                return equipment.Sum(e => e.Weight);
            }
        }
        public ICollection<IEquipment> Equipment
        {
            get
            {
                return equipment;
            }
        }
        public ICollection<IAthlete> Athletes
        {
            get
            {
                return athletes;
            }
        }
        public void AddAthlete(IAthlete athlete)
        {
            if (athletes.Count >= Capacity)
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }
            athletes.Add(athlete);
        }
        public void AddEquipment(IEquipment equipment)
        {
            this.equipment.Add(equipment);
        }
        public void Exercise()
        {
            foreach (var athlete in athletes)
            {
                athlete.Exercise();
            }
        }
        public string GymInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Name} is a {this.GetType().Name}");
            sb.AppendLine($"Athletes: {(this.Athletes.Any() ? string.Join(", ", this.Athletes.Select(a => a.FullName)) : "No athletes")}");
            sb.AppendLine($"Equipment total count: {this.Equipment.Count}");
            sb.AppendLine($"Equipment total weight: {Equipment.Sum(e => e.Weight)} grams");
            return sb.ToString().TrimEnd();
        }
        public bool RemoveAthlete(IAthlete athlete)
        {
            return athletes.Remove(athlete);
        }
    }
}
