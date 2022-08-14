using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.MilitaryUnits
{
    public class AnonymousImpactUnit : MilitaryUnit
    {
        private const double AnonymousImpactUnitsCost = 30.0d;
        public AnonymousImpactUnit() : base(AnonymousImpactUnitsCost)
        {

        }
    }
}
