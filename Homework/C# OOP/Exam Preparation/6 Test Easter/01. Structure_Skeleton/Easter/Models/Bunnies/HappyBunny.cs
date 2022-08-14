using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Bunnies
{
    public class HappyBunny : Bunny
    {
        private const int HappyBunnyStartEnergy = 100;
        public HappyBunny(string name) : base(name, HappyBunnyStartEnergy)
        {

        }
        public override void Work()
        {
            this.Energy -= 10;
        }
    }
}
