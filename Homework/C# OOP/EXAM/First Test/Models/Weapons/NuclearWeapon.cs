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
                if (base.ValidateDestructionLevel(value))
                {
                    destructionLevel = value;
                }
            }
        }
    }
}
