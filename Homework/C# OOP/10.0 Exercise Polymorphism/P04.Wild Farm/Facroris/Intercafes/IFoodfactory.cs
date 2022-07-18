using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Facroris.Intercafes
{
    using Models.Foods;
    public interface IFoodfactory
    {
        Food CreateFood(string type, int quantity);
    }
}
