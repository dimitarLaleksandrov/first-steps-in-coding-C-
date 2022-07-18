using System;
using System.Collections.Generic;
using System.Text;
using P04.WildFarm.Models.Foods;

namespace P04.WildFarm.Models.Animals.Mammals
{
    public class Cat : Feline
    {
        private const double CatWeightMultiplier = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {

        }

        protected override IReadOnlyCollection<Type> PrefferedFood => new List<Type> { typeof(Vegetable), typeof(Meat) }.AsReadOnly();

        protected override double WeightMultiplier => CatWeightMultiplier;

        public override string ProduceSounde()
        {
            return "Meow";
        }
    }
}
