using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent
{
    internal class CitiesByContinent
    {  
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentsInfo = new Dictionary<string, Dictionary<string, List<string>>>();
            int continentsToCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= continentsToCount; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string continent = info[0];
                string contry = info[1];
                string contryCity = info[2];
                if (!continentsInfo.ContainsKey(continent))
                {
                    continentsInfo.Add(continent, new Dictionary<string, List<string>>());
                    continentsInfo[continent].Add(contry, new List<string>());
                    continentsInfo[continent][contry].Add(contryCity);         
                }
                else
                {
                    if (!continentsInfo[continent].ContainsKey(contry))
                    {
                        continentsInfo[continent].Add(contry, new List<string>());
                        continentsInfo[continent][contry].Add(contryCity);
                    }
                    else
                    {
                        
                        continentsInfo[continent][contry].Add(contryCity);
        
                    }
                }
            }
            foreach (var continent in continentsInfo)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var contry in continent.Value)
                {
                    Console.WriteLine($"  {contry.Key} -> {string.Join(", ", contry.Value)}");
                }
            }
        }
    }
}
