using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P04.WildFarm.Models.Foods;
using P04.WildFarm.Exeptions;

namespace P04.WildFarm.Models.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        protected abstract IReadOnlyCollection<Type> PrefferedFood { get; }
        protected abstract double WeightMultiplier { get; }
        public abstract string ProduceSounde();
        public void Eat( Food food)
        {
            if (this.PrefferedFood.Contains(food.GetType()))
            {
                throw new FoodNotPrefurdExeption(String.Format(ExceptionMeseges.FoodNotPrefered, this.GetType().Name, food.GetType().Name));
            }
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.WeightMultiplier;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name},";
        }
    }
}
