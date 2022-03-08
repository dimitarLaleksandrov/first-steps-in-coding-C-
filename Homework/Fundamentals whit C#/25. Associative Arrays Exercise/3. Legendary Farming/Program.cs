using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int lenderiQuantity = 250;
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("motes", 0);
            materials.Add("fragments", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string legenderiItem = string.Empty;
            bool legenderi = false;
            while (!legenderi)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    string material = input[i + 1].ToLower();
                    int quantity = int.Parse(input[i]);
                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;
                        if (materials[material] >= lenderiQuantity)
                        {
                            legenderi = true;
                            legenderiItem = material;
                            materials[legenderiItem] -= lenderiQuantity;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }
            }
            PrintLegenderiItem(legenderiItem, materials);
            PrintMaterialANdJunk(materials, junk); 
        }
        static void PrintMaterialANdJunk (Dictionary<string, int> materials, Dictionary<string, int> junk)
        {
            foreach (var kvp in materials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
        static void PrintLegenderiItem (string legenderiItem, Dictionary<string, int> materials)
        {
            if (legenderiItem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (legenderiItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (legenderiItem == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }    
        }
    }
}
