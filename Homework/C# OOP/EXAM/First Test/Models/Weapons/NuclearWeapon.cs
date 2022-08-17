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
        }
    }
}
