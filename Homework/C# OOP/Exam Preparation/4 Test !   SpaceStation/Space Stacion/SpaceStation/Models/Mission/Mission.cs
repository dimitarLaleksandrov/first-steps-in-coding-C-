using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            var planetItems = planet.Items;
            foreach (var astronaut in astronauts)
            {
                if (astronaut.CanBreath)
                {
                    foreach (var item in planetItems)
                    {
                        astronaut.Breath();
                        if (astronaut.CanBreath)
                        {
                            astronaut.Bag.Items.Add(item);
                            planet.Items.Remove(item);
                        }         
                    }     
                }
                planetItems = planet.Items;
            }
        }
    }
}
