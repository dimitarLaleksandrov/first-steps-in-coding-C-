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
            this.units = new UnitRepository();
            this.weapons = new WeaponRepository();
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
            get 
            {
                double totalAmount = (this.units.Models.Sum(m => m.EnduranceLevel)) + (this.weapons.Models.Sum(m => m.DestructionLevel));
                var anonymousImpactUnit = this.Army.Any(a => a.GetType().Name == "AnonymousImpactUnit");
                var nuclearWeapon = this.Weapons.Any(w => w.GetType().Name == "NuclearWeapon");
                if (anonymousImpactUnit)
                {
                    totalAmount += (totalAmount * 0.30d);
                }
                else if (nuclearWeapon)
                {
                    totalAmount += (totalAmount * 0.45d);
                }
                return Math.Round(totalAmount, 3);
            }
        }

        public IReadOnlyCollection<IMilitaryUnit> Army => this.units.Models;

        public IReadOnlyCollection<IWeapon> Weapons => this.weapons.Models;

        public void AddUnit(IMilitaryUnit unit)
        {
            //this.units.AddItem(unit);
            if (units.FindByName(unit.GetType().Name) == null)
            {
                this.units.AddItem(unit);
            }
        }

        public void AddWeapon(IWeapon weapon)
        {
            //this.weapons.AddItem(weapon);
            if (weapons.FindByName(weapon.GetType().Name) == null)
            {
                this.weapons.AddItem(weapon);
            }
        }

        public string PlanetInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Planet: {Name}");
            sb.AppendLine($"--Budget: {Budget} billion QUID");
            sb.AppendLine($"--Forces: {(Army.Any() ? string.Join(", ", Army.Select(a => a.GetType().Name)) : "No units")}");
            sb.AppendLine($"--Combat equipment: {(Weapons.Any() ? string.Join(", ", Weapons.Select(w => w.GetType().Name)) : "No weapons")}");
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
