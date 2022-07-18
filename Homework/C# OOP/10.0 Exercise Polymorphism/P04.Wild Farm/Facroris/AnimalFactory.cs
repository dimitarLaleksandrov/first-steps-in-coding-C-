using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Facroris
{
    using Intercafes;
    using Models.Animals;
    using Exeptions;
    using P04.WildFarm.Models.Animals.Birds;
    using P04.WildFarm.Models.Animals.Mammals;

    public class AnimalFactory : IAnimaleFactory
    {
        public Animal CreateAnimal(string type, string name, double weight, string therdparam, string forthparam = null)
        {
            Animal animal;
            if (type == "Owl")
            {
                animal = new Owl(name, weight, double.Parse(therdparam));
            }
            else if (type == "Hen")
            {
                animal = new Hen(name, weight, double.Parse(therdparam));
            }
            else if (type == "Mouse")
            {
                animal = new Mouse(name, weight, therdparam);
            }
            else if (type == "Dog")
            {
                animal = new Dog(name, weight, therdparam);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, weight, therdparam, forthparam);
            }
            else if (type == "Tiger")
            {
                animal = new Tiger(name, weight, therdparam, forthparam);
            }
            else
            {
                throw new InvalidFactoriTypeExeption();
            }
            return animal;
        }
    }
}
