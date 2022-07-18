using System;
using System.Collections.Generic;
using System.Text;
using P04.WildFarm.Models.Foods;

namespace P04.WildFarm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        private const double OwlWeightMultiplier = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }
        protected override IReadOnlyCollection<Type> PrefferedFood => new List<Type> {typeof(Meat)}.AsReadOnly();

        protected override double WeightMultiplier => OwlWeightMultiplier;

        public override string ProduceSounde()
        {
            return "Hoot Hoot";
        }
    }
}
