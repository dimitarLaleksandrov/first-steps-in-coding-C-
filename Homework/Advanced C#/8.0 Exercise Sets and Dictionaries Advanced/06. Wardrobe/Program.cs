using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Wardrobe
    {
        static void Main(string[] args)
        {
            int loopNums = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 1; i <= loopNums; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string collor = input[0];
                string[] cloth = input[1].Split(",");
                if (!clothes.ContainsKey(collor))
                {
                    clothes.Add(collor, new Dictionary<string, int>());
                    foreach (var c in cloth)
                    {
                        if (!clothes[collor].ContainsKey(c))
                        {
                            clothes[collor].Add(c, 1);
                        }
                        else
                        {
                            clothes[collor][c]++;
                        }
                    }
                }
                else
                {
                    foreach (var c in cloth)
                    {
                        if (!clothes[collor].ContainsKey(c))
                        {
                            clothes[collor].Add(c, 1);
                        }
                        else
                        {
                            clothes[collor][c]++;
                        }
                    }
                }
            }
            string[] dressToFound = Console.ReadLine().Split(" ");
            string clotheColor = dressToFound[0];
            string clothe = dressToFound[1];
            foreach (var collor in clothes)
            {
                Console.WriteLine($"{collor.Key} clothes:");
                foreach (var cloth in collor.Value)
                {
                    if (cloth.Key.Contains(clothe) && collor.Key.Contains(clotheColor))
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
            
        }
    }
}
