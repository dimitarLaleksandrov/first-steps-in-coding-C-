﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Models.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
        public string LivingRegion { get; }

    }
}
