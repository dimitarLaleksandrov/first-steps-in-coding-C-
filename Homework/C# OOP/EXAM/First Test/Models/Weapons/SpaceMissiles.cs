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
