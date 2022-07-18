using System;
using System.Collections.Generic;
using System.Text;
using P04.WildFarm.Models.Foods;

namespace P04.WildFarm.Models.Animals.Mammals
{
    public class Tiger : Feline
    {
        private const double CatWeightMultiplier = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {

        }

        protected override IReadOnlyCollection<Type> PrefferedFood => new List<Type> { typeof(Meat) }.AsReadOnly();

        protected override double WeightMultiplier => CatWeightMultiplier;

        public override string ProduceSounde()
        {
            return "ROAR!!!";
        }
    }
}
