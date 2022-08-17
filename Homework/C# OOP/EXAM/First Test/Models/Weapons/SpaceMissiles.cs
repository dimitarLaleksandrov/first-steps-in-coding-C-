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
        }
    }
}
