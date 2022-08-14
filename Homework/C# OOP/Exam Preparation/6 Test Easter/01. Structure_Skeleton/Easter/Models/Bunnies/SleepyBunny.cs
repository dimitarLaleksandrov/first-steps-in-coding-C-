using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Bunnies
{
    public class SleepyBunny : Bunny
    {
        private const int SleepyBunnyStartEnergy = 50;
        public SleepyBunny(string name) : base(name, SleepyBunnyStartEnergy)
        {

        }
        public override void Work()
        {
            this.Energy -= 15;
        }
    }
}
