using PlanetWars.Core.Contracts;
using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.Planets;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var planet = planets.FindByName(planetName);
            if (planet == null)
            {
                throw new InvalidOperationException($"Planet {planetName} does not exist!");
            }
            if (unitTypeName != "AnonymousImpactUnit" && unitTypeName != "SpaceForces" && unitTypeName != "StormTroopers")
            {
                throw new InvalidOperationException($"{unitTypeName} still not available!");
            }
            if (planet.Army.Any(a => a.GetType().Name == unitTypeName))
            {
                throw new InvalidOperationException($"{unitTypeName} already added to the Army of {planetName}!");
            }
            switch (unitTypeName)
            {
                case "AnonymousImpactUnit":
                    var unitA = new AnonymousImpactUnit();
                    planet.Spend(unitA.Cost);
                    planet.AddUnit(unitA);                 
                    break;
                case "SpaceForces":
                    var unitS = new SpaceForces();
                    planet.Spend(unitS.Cost);
                    planet.AddUnit(unitS);
                    break;
                case "StormTroopers":
                    var unit = new StormTroopers();
                    planet.Spend(unit.Cost);
                    planet.AddUnit(unit);                  
                    break;
                default:
                    break;
            }
            return $"{unitTypeName} added successfully to the Army of {planetName}!";
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            var planet = planets.FindByName(planetName);
            var weapon = planet.Weapons.FirstOrDefault(w => w.GetType().Name == weaponTypeName);
            if(planet == null)
            {
                throw new InvalidOperationException($"Planet {planetName} does not exist!");
            }
            if(weapon != null)
            {
                throw new InvalidOperationException($"{weaponTypeName} already added to the Weapons of {planetName}!");
            }
            if (weaponTypeName != "BioChemicalWeapon" && weaponTypeName != "NuclearWeapon" && weaponTypeName != "SpaceMissiles")
            {
                throw new InvalidOperationException($"{weaponTypeName} still not available!");
            }
            switch (weaponTypeName)
            {
                case "BioChemicalWeapon":
                    var weaponB = new BioChemicalWeapon(destructionLevel);
                    planet.Spend(weaponB.Price);
                    planet.AddWeapon(weaponB);
                    break;
                case "NuclearWeapon":
                    var weaponN = new NuclearWeapon(destructionLevel);
                    planet.Spend(weaponN.Price);
                    planet.AddWeapon(weaponN);     
                    break;
                case "SpaceMissiles":
                    var weaponS = new SpaceMissiles(destructionLevel);
                    planet.Spend(weaponS.Price);
                    planet.AddWeapon(weaponS);
                    break;
                default:
                    break ;
            }            
            return $"{planetName} purchased {weaponTypeName}!";
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
            var sb = new StringBuilder();
            sb.AppendLine("***UNIVERSE PLANET MILITARY REPORT * **");
            foreach (var planet in planets.Models)
            {
                sb.Append(planet.PlanetInfo());
            }
            return sb.ToString();
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            var planet1 = planets.FindByName(planetOne);
            var planet2 = planets.FindByName(planetTwo);
            var NucWeaponPlanetOne = planet1.Weapons.FirstOrDefault(w => w.GetType().Name == "NuclearWeapon");
            var NucWeaponPlanetTwo = planet2.Weapons.FirstOrDefault(w => w.GetType().Name == "NuclearWeapon");
            var planetOneWint = false;
            if (planet1.MilitaryPower == planet2.MilitaryPower)
            {   
                if (NucWeaponPlanetOne != null)
                {                  
                    planetOneWint = true;
                }              
                if (NucWeaponPlanetOne != null && NucWeaponPlanetTwo != null || NucWeaponPlanetOne == null && NucWeaponPlanetTwo == null)
                {
                    planet1.Spend(planet1.Budget / 2);
                    planet2.Spend(planet2.Budget / 2);
                    return $"The only winners from the war are the ones who supply the bullets and the bandages!";
                }
            }
            if (planetOneWint || planet1.MilitaryPower > planet2.MilitaryPower)
            {
                planet1.Spend(planet1.Budget / 2);
                planet1.Profit(planet2.Budget / 2);
                var moreMoneyToAdd = planet2.Army.Sum(a => a.Cost) + planet2.Weapons.Sum(w => w.Price);
                planet1.Profit(moreMoneyToAdd);
                planets.RemoveItem(planetTwo);
                return $"{planetOne} destructed {planetTwo}!";
            }
            else
            {
                planet2.Spend(planet2.Budget / 2);
                planet2.Profit(planet1.Budget / 2);
                var moreMOneyToAdd = planet1.Army.Sum(a => a.Cost) + planet1.Weapons.Sum(w => w.Price);
                planet2.Profit(moreMOneyToAdd);
                planets.RemoveItem(planetOne);
                return $"{planetTwo} destructed {planetOne}!";
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
            planet.Spend(1.25d);
            planet.TrainArmy();
            return $"{planetName} has upgraded its forces!";
        }
    }
}
