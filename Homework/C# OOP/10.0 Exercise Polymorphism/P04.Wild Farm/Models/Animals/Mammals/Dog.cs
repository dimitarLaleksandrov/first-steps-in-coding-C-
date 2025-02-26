﻿using System;
using System.Collections.Generic;
using System.Text;
using P04.WildFarm.Models.Foods;

namespace P04.WildFarm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double DogWeightMultiplier = 0.40;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }
        protected override IReadOnlyCollection<Type> PrefferedFood => new List<Type> {typeof(Meat) }.AsReadOnly();

        protected override double WeightMultiplier => DogWeightMultiplier;

        public override string ProduceSounde()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return base.ToString() + $" {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
