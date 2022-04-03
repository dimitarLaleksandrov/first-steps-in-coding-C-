using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    public class Hero
    {
        public Hero(string name)
        {
            Name = name;
            Spells = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Spells { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string commands;
            var heroes = new List<Hero>();
            var messages = new List<string>();
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] command = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string comArg = command[0];
                if (comArg == "Enroll")
                {
                    string nameOfTheHero = command[1];
                    if (heroes.Any(h => h.Name == nameOfTheHero))
                    {
                        messages.Add($"{nameOfTheHero} is already enrolled.");
                    }
                    else
                    {
                        Hero hero = new Hero(nameOfTheHero);
                        heroes.Add(hero);
                    }
                }
                else if (comArg == "Learn")
                {
                    string nameOfTheHero = command[1];
                    string spellName = command[2];
                    if (!heroes.Any(h => h.Name == nameOfTheHero))
                    {
                        messages.Add($"{nameOfTheHero} doesn't exist.");
                    }
                    else
                    {
                        var hero = heroes.Find(h => h.Name == nameOfTheHero);
                        if (hero.Spells.Contains(spellName))
                        {
                            messages.Add($"{nameOfTheHero} has already learnt {spellName}.");
                        }
                        else
                        {
                            hero.Spells.Add(spellName);
                        }
                    }
                }
                else if (comArg == "Unlearn")
                {
                    string nameOfTheHero = command[1];
                    string spellName = command[2];
                    if (!heroes.Any(h => h.Name == nameOfTheHero))
                    {
                        messages.Add($"{nameOfTheHero} doesn't exist.");
                    }
                    else
                    {
                        var hero = heroes.Find(h => h.Name == nameOfTheHero);
                        if (!hero.Spells.Contains(spellName))
                        {
                            messages.Add($"{nameOfTheHero} doesn't know {spellName}.");                          
                        }
                        else
                        {
                            hero.Spells.Remove(spellName);
                        }
                        
                    }               
                }
            }
            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Name}: {string.Join(", ", hero.Spells)}");
            }
        }    
    }
}

