using System;

namespace P04.WildFarm
{
    using Facroris;
    using Facroris.Intercafes;
    using Core;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IFoodfactory foodfactory = new FoodFactory();
            IAnimaleFactory animaleFactory = new AnimalFactory();
            IEngine engen = new Engine(animaleFactory, foodfactory);
            engen.Start();
        }
    }
}
