using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;
        private double budget;
        private double militaryPower;
        private readonly UnitRepository units;
        private readonly WeaponRepository weapons;
        public Planet(string name, double budget)
        {
            this.Name = name;
            this.Budget = budget;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Planet name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public double Budget
        {
            get { return this.budget; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Budget's amount cannot be negative.");
                }
                this.budget = value;
            }
        }

        public double MilitaryPower
        {
            get { return this.militaryPower; }
            private set
            {
                double TotalAmount = (this.units.Models.Sum(m => m.EnduranceLevel)) + (this.weapons.Models.Sum(m => m.DestructionLevel));
                var AnonymousImpactUnit = this.Army.Any(a => a.GetType().Name == "AnonymousImpactUnit");
                var NuclearWeapon = this.Weapons.Any(w => w.GetType().Name == "NuclearWeapon");
                if (AnonymousImpactUnit)
                {
                    TotalAmount += (TotalAmount * 0.30d);
                }
                else if (NuclearWeapon)
                {
                    TotalAmount += (TotalAmount * 0.45d);
                }
                value = TotalAmount;
                this.militaryPower = Math.Round(value, 3);
            }
        }

        public IReadOnlyCollection<IMilitaryUnit> Army => this.units.Models;

        public IReadOnlyCollection<IWeapon> Weapons => this.weapons.Models;

        public void AddUnit(IMilitaryUnit unit)
        {
            this.units.AddItem(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.AddItem(weapon);
        }

        public string PlanetInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Planet: {Name}");
            sb.AppendLine($"--Budget: {Budget} billion QUID");
            sb.Append("--Forces: ");
            if (Army.Count == 0)
            {
                sb.AppendLine("No units");
            }
            else
            {
                sb.AppendLine(String.Join(", ", units.Models));
            }
            sb.Append("--Combat equipment: ");
            if(Weapons.Count == 0)
            {
                sb.AppendLine("No weapons");
            }
            else
            {
                sb.AppendLine(String.Join(", ", weapons.Models));
            }
            sb.AppendLine($"--Military Power: {MilitaryPower}");
            return sb.ToString();
        }

        public void Profit(double amount)
        {
            this.Budget += amount;
        }

        public void Spend(double amount)
        {
            if (this.Budget < amount)
            {
                throw new InvalidOperationException("Budget too low!");
            }
            this.Budget -= amount;
        }

        public void TrainArmy()
        {
            foreach (var unit in Army)
            {
                unit.IncreaseEndurance();
            }
        }
    }
}
