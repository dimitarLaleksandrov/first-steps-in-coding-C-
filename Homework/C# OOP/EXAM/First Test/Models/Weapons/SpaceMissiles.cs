using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public class SpaceMissiles :  Weapon
    {
        private const double SpaceMissilesPrice = 8.75d;
        private int destructionLevel;
        public SpaceMissiles(int destructionLevel) : base(destructionLevel, SpaceMissilesPrice)
        {
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
        }
    }
}
