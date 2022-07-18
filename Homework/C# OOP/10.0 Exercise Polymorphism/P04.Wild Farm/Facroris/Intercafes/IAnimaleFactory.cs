using P04.WildFarm.Models.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Facroris.Intercafes
{
    public interface IAnimaleFactory
    {
        Animal CreateAnimal(string type, string name, double weight, string therdparam, string forthparam = null);
    }
}
