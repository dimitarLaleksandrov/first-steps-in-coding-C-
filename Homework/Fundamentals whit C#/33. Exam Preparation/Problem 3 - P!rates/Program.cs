using System;
using System.Collections.Generic;

namespace Problem_3___P_rates
{
    internal class Program
    {
        class Towns   
        {  
            public Towns(string TownName, int Population, int Gold)
            {
                this.TownName = TownName;
                this.Population = Population;
                this.Gold = Gold;
            }
            public string TownName { get; set; }
            public int Population { get; set; } 
            public int Gold { get; set; }
        }

        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Towns> citys = new Dictionary<string, Towns>();
            while (command[0] != "Sail")
            {
                string cityName = command[0];
                int population = int.Parse(command[1]);
                int gold = int.Parse(command[2]);
                if (citys.ContainsKey(cityName))
                {
                    citys[cityName].Population += population;
                    citys[cityName].Gold += gold;
                }
                else
                {
                    Towns newTown = new Towns(cityName, population, gold);
                    citys.Add(cityName, newTown);
                }
                command = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            }
            string[] secondCommand = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            while (secondCommand[0] != "End")
            {
                if (secondCommand[0] == "Plunder")
                {
                    string cityToPlunder = secondCommand[1];
                    int population = int.Parse(secondCommand[2]);
                    int goldToSteal = int.Parse(secondCommand[3]);
                    citys[cityToPlunder].Population -= population;
                    citys[cityToPlunder].Gold -= goldToSteal;
                    Console.WriteLine($"{cityToPlunder} plundered! {goldToSteal} gold stolen, {population} citizens killed.");
                    if (citys[cityToPlunder].Population <= 0 || citys[cityToPlunder].Gold <= 0)
                    {
                        Console.WriteLine($"{cityToPlunder} has been wiped off the map!");
                        citys.Remove(cityToPlunder);
                    }
                }
                else if (secondCommand[0] == "Prosper")
                {
                    string cityToProsper = secondCommand[1];
                    int goldToAdd = int.Parse(secondCommand[2]);
                    if (goldToAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        secondCommand = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else
                    {
                        citys[cityToProsper].Gold += goldToAdd;
                        Console.WriteLine($"{goldToAdd} gold added to the city treasury. {cityToProsper} now has {citys[cityToProsper].Gold} gold.");
                    }
                }
                secondCommand = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }
            if (citys.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {citys.Count} wealthy settlements to go to:");
                foreach (var city in citys)
                {
                    Console.WriteLine($"{city.Value.TownName} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
        }
    }
}
