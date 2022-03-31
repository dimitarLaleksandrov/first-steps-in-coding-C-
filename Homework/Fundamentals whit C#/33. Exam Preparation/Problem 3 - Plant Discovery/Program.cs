using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRatings = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string plantName = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);
                plantRarity[plantName] = rarity;
            }
            string commandInfo;
            while ((commandInfo = Console.ReadLine()) != "Exhibition")
            {
                string[] command = commandInfo.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = command[0];
                string[] cmdArgu = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string plantName = cmdArgu[0];
                if (cmdType == "Rate")
                {
                    double plantRating = double.Parse(cmdArgu[1]);
                    if (!plantRarity.ContainsKey(plantName))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    if (!plantRatings.ContainsKey(plantName))
                    {
                        plantRatings[plantName] = new List<double>();
                    }
                    plantRatings[plantName].Add(plantRating);
                }
                else if (cmdType == "Update")
                {
                    int newRarity = int.Parse(cmdArgu[1]);
                    if (plantRarity.ContainsKey(plantName))
                    {
                        plantRarity[plantName] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdType == "Reset")
                {
                    if (!plantRarity.ContainsKey(plantName))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    if (plantRatings.ContainsKey(plantName))
                    {
                        plantRatings[plantName].Clear();
                    }
                }
            }
           PrintOutputInfo(plantRarity, plantRatings);
        }
        static void PrintOutputInfo(Dictionary<string, int> plantRarity, Dictionary<string, List<double>> plantRatings)
        {
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var kvp in plantRarity)
            {
                string plantName = kvp.Key;
                int rarity = kvp.Value;
                double avarigRaiting = 0;
                if (plantRatings.ContainsKey(plantName) && plantRatings[plantName].Any())
                {
                    avarigRaiting = plantRatings[plantName].Average();
                }
                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {avarigRaiting:f2}");
            }
        }
    }
}
