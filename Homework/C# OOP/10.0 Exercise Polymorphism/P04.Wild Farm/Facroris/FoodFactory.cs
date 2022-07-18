using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Facroris
{
    using Intercafes;
    using Models.Foods;
    using Exeptions;

    public class FoodFactory : IFoodfactory
    {
        public Food CreateFood(string type, int quantity)
        {
            Food food;
            if(type == "Vegetables")
            {
                food = new Vegetable(quantity);
            }
            else if (type == "Fruit")
            {
                food = new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                food = new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                food = new Seeds(quantity);
            }
            else
            {
                throw new InvalidFactoriTypeExeption();
            }
            return food;
        }
    }
}
