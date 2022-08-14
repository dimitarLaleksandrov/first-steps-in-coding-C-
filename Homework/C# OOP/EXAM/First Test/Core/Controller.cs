using PlanetWars.Core.Contracts;
using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.Planets;
using PlanetWars.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Core
{
    public class Controller : IController
    {
        private readonly PlanetRepository planets;
        public Controller()
        {
            this.planets = new PlanetRepository();
        }
        public string AddUnit(string unitTypeName, string planetName)
        {
            var unitType = planets.FindByName(planetName).Army.GetType().Name == unitTypeName;
            if (planets.FindByName(planetName) == null)
            {
                throw new InvalidOperationException($"Planet {planetName} does not exist!");
            }
            if ()
            {

            }
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            throw new NotImplementedException();
        }

        public string CreatePlanet(string name, double budget)
        {
            var planet = planets.FindByName(name);
            if(planet != null)
            {
                return $"Planet {planet.Name} is already added!"; 
            }
            var planetToAdd = new Planet(name, budget);
            planets.AddItem(planetToAdd);
            return $"Successfully added Planet: {name}";
        }

        public string ForcesReport()
        {
            throw new NotImplementedException();
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            var planet1 = planets.FindByName(planetOne);
            var planet2 = planets.FindByName(planetTwo);


            if (planet1.MilitaryPower == planet2.MilitaryPower)
            {

            }
        }

        public string SpecializeForces(string planetName)
        {
            var planet = planets.FindByName(planetName);
            if (planet == null)
            {
                throw new InvalidOperationException($"Planet {planetName} does not exist!");
            }
            if (planet.Army.Count == 0)
            {
                throw new InvalidOperationException($"No units available for upgrade!");
            }
            planet.Army.
        }
    }
}
