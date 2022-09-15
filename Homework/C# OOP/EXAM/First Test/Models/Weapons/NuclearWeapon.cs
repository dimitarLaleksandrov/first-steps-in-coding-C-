using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public class NuclearWeapon : Weapon
    {
        private const double NuclearWeaponPrice = 15.0d;
        public NuclearWeapon(int destructionLevel) : base(destructionLevel, NuclearWeaponPrice)
        {
<<<<<<< HEAD
            this.DestructionLevel = destructionLevel;
        }
        public override int DestructionLevel
        {
            get
            {
                return this.destructionLevel;
            }
            protected set
            {
                if (base.ValidateDestructionLevel(value))
                {
                    destructionLevel = value;
                }
            }
=======
>>>>>>> 0a4fa02efdd9b285fcd9b13367e5f1b314b56cf0
        }
    }
}
