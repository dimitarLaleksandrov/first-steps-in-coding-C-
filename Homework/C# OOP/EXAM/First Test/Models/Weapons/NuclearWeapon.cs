using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public class NuclearWeapon : Weapon
    {
        private const double NuclearWeaponPrice = 15.0d;
        private int destructionLevel;
        public NuclearWeapon(int destructionLevel) : base(destructionLevel, NuclearWeaponPrice)
        {
            this.DestructionLevel = destructionLevel;
        }
        public override int DestructionLevel
        {
            get
            {
                return this.destructionLevel;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Destruction level cannot be zero or negative.");
                }
                else if (value > 10)
                {
                    throw new ArgumentException("Destruction level cannot exceed 10 power points.");
                }
                this.destructionLevel = value;
            }
        }
    }
}
