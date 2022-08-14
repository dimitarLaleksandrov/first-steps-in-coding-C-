using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public abstract class Vessel : IVersion
    {
        private string name;
        private double armorThickness;
        private double mainWeaponCaliber;
        private double speed;
        private ICollection<string> targets;
        private ICaptain captain;

        protected Vessel(string name, double mainWeaponCaliber, double speed, double armorThickness)
        {
            this.Name = name;
            this.MainWeaponCaliber = mainWeaponCaliber;
            this.Speed = speed;
            this.ArmorThickness = armorThickness;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Vessel name cannot be null or empty.");
                }
                this.name = value;
            }
        }
        public ICaptain Captain
        {
            get { return this.captain; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Captain cannot be null.");
                }
                this.captain = value;
            }
        }
        public double ArmorThickness
        {
            get { return this.armorThickness; }
            set { this.armorThickness = value; }
        }

        public double MainWeaponCaliber
        {
            get { return this.mainWeaponCaliber; }
            set { this.mainWeaponCaliber = value; }
        }

        public double Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public ICollection<string> Targets
        {
            get { return this.targets; }
            set
            {
                this.targets = value;
            }
        }

        public void Attack(IVersion target)
        {
            if (target == null)
            {
                throw new NullReferenceException("Target cannot be null.");
            }
            target.ArmorThickness -= this.MainWeaponCaliber;
            if(target.ArmorThickness < 0)
            {
                target.ArmorThickness = 0;
            }
            this.Targets.Add(target.Name);
        }

        public void RepairVessel()
        {
            this.ArmorThickness = armorThickness;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"- {this.Name}");
            sb.AppendLine($"*Armor thickness: {this.ArmorThickness}");
            sb.AppendLine($"*Main weapon caliber: {this.MainWeaponCaliber}");
            sb.AppendLine($"*Speed: {this.Speed} knots");
            sb.AppendLine($"*Targets: " + this.Targets == null ? "None" : $"{string.Join(", ", this.Targets)}");
            return sb.ToString();
        }
    }
}
