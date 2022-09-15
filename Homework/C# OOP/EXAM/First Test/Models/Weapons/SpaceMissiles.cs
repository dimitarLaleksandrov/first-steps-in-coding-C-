using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public class SpaceMissiles :  Weapon
    {
        private const double SpaceMissilesPrice = 8.75d;
        public SpaceMissiles(int destructionLevel) : base(destructionLevel, SpaceMissilesPrice)
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
