using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> heroes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string heroName = line[0];
                int hp = int.Parse(line[1]);
                int mp = int.Parse(line[2]);
                if (!heroes.ContainsKey(heroName))
                {
                    heroes.Add(heroName, new Dictionary<string, int>()
                {
                    {"hp", hp },
                    {"mp", mp }
                });
                }
                else
                {
                    heroes[heroName]["hp"] = hp;
                    heroes[heroName]["mp"] = mp;
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] line = command.Split(" - ");
                string cmd = line[0];
                if (cmd == "CastSpell")
                {
                    string heroName = line[1];
                    int mpNeeded = int.Parse(line[2]);
                    string spellName = line[3];
                    if (heroes[heroName]["mp"] >= mpNeeded)
                    {
                        heroes[heroName]["mp"] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName]["mp"]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmd == "TakeDamage")
                {
                    string heroName = line[1];
                    int damage = int.Parse(line[2]);
                    string spellName = line[3];
                    if (heroes[heroName]["hp"] - damage > 0)
                    {
                        heroes[heroName]["hp"] -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {spellName} and now has {heroes[heroName]["hp"]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {spellName}!");
                        heroes.Remove(heroName);
                    }
                }
                else if (cmd == "Recharge")
                {
                    string heroName = line[1];
                    int rechargeHp = int.Parse(line[2]);
                    int totalMp = heroes[heroName]["mp"] + rechargeHp;
                    if (totalMp > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - heroes[heroName]["mp"]} MP!");
                        heroes[heroName]["mp"] = 200;
                    }
                    else
                    {                      
                        heroes[heroName]["mp"] = totalMp;
                        Console.WriteLine($"{heroName} recharged for {rechargeHp} MP!");
                    }
                }
                else if (cmd == "Heal")
                {
                    string heroName = line[1];
                    int neededHp = int.Parse(line[2]);
                    int totalHp = heroes[heroName]["hp"] + neededHp;
                    if (totalHp > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroes[heroName]["hp"]} HP!");
                        heroes[heroName]["hp"] = 100;
                    }
                    else
                    {
                        heroes[heroName]["hp"] = totalHp;
                        Console.WriteLine($"{heroName} healed for {neededHp} HP!");
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in heroes)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {heroes[item.Key]["hp"]}");
                Console.WriteLine($"  MP: {heroes[item.Key]["mp"]}");
            }                  
        }
    }
}
