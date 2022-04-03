using System;
using System.Collections.Generic;

namespace Problem_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commands;
            Dictionary<string, List<string>> heros = new Dictionary<string, List<string>>();
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] command = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string comArg = command[0];
                if (comArg == "Enroll")
                {
                    string nameOfTheHero = command[1];
                    if (!heros.ContainsKey(nameOfTheHero))
                    {
                        heros.Add(nameOfTheHero, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfTheHero} is already enrolled.");
                    }
                }
                else if (comArg == "Learn")
                {
                    string nameOfTheHero = command[1];
                    string spellName = command[2];
                    if (!heros.ContainsKey(nameOfTheHero))
                    {
                        Console.WriteLine($"{nameOfTheHero} doesn't exist.");
                    }
                    else
                    {
                        if (heros[nameOfTheHero].Contains(spellName))
                        {
                            Console.WriteLine($"{nameOfTheHero} has already learnt {spellName}.");
                        }
                        else
                        {
                            heros[nameOfTheHero].Add(spellName);
                        }
                    }
                }
                else if (comArg == "Unlearn")
                {
                    string nameOfTheHero = command[1];
                    string spellName = command[2];
                    if (!heros.ContainsKey(nameOfTheHero))
                    {
                        Console.WriteLine($"{nameOfTheHero} doesn't exist.");
                    }
                    else
                    {
                        if (!heros[nameOfTheHero].Contains(spellName))
                        {
                            Console.WriteLine($"{nameOfTheHero} doesn't know {spellName}.");
                        }
                        else
                        {
                            heros[nameOfTheHero].Remove(spellName);
                        }
                    }
                }
            }
            Console.WriteLine("Heroes:");
            foreach (var hero in heros)
            {
                Console.WriteLine(($"== {hero.Key}: {string.Join(", ", hero.Value)}"));
            }
        }
    }
}
