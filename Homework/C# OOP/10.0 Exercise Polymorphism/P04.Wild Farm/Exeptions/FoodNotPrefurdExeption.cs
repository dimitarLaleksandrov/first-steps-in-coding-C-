using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Exeptions
{
    public class FoodNotPrefurdExeption : Exception
    {
        public FoodNotPrefurdExeption(string message) : base(message)
        {

        }
    }
}
