using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int plantComfort = 5;
        private const decimal plantPrice = 10m;
        public Plant() : base(plantComfort, plantPrice)
        {

        }
    }
}
