using System;
using System.Collections.Generic;
using System.Text;
using P04.WildFarm.Models.Foods;

namespace P04.WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double HenWeightMultiplier = 0.35;
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }

        protected override IReadOnlyCollection<Type> PrefferedFood => new List<Type> { typeof(Fruit), typeof(Meat), typeof(Seeds), typeof(Vegetable) }.AsReadOnly();

        protected override double WeightMultiplier => HenWeightMultiplier;

        public override string ProduceSounde()
        {
            return "Cluck";
        }
    }
}
