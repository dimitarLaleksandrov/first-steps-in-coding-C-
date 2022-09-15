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
