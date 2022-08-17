using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public class BioChemicalWeapon : Weapon
    {
        private const double BioChemicalWeaponPrice = 3.20d;
        public BioChemicalWeapon(int destructionLevel) : base(destructionLevel, BioChemicalWeaponPrice)
        {
        }
    }
}
