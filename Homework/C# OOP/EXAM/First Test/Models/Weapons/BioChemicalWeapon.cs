using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public class BioChemicalWeapon : Weapon
    {
        private const double BioChemicalWeaponPrice = 3.20d;
        private int destructionLevel;
        public BioChemicalWeapon(int destructionLevel) : base(destructionLevel, BioChemicalWeaponPrice)
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
