using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Models
{
    public class Captain : ICaptain
    {
        private string fullName;
        private int combatExperience;
        private ICollection<IVersion> vessels;
        public Captain(string fullName)
        {
            this.FullName = fullName;
            this.CombatExperience = 0;
            this.Vessels = new List<IVersion>();
        }
        public string FullName
        {
            get { return this.fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Captain full name cannot be null or empty string.");
                }
                this.fullName = value;
            }
        }

        public int CombatExperience
        {
            get { return this.combatExperience; }
            private set
            {
                this.combatExperience = value;
            }
        }
        public ICollection<IVersion> Vessels
        {
            get { return this.vessels; }
            private set { this.vessels = value; }
        }

        public void AddVessel(IVersion vessel)
        {
            if (vessel == null)
            {
                throw new NullReferenceException("Null vessel cannot be added to the captain.");
            }
            this.Vessels.Add(vessel);
        }

        public void IncreaseCombatExperience()
        {
            this.CombatExperience += 10;
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.FullName} has {this.CombatExperience} combat experience and commands {this.Vessels.Count} vessels.");
            if(this.Vessels.Count > 0)
            {
                foreach (var v in this.Vessels)
                {
                    sb.Append(v.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
