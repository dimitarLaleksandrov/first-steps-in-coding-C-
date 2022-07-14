using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string FavoriteFood 
        { 
            get { return favouriteFood; }
            private set { favouriteFood = value; }
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favorite food is {this.FavoriteFood}";
        }
    }
}
