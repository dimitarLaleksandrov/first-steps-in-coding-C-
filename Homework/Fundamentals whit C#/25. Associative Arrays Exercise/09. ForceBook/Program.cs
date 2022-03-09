using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "Lumpawaroo")
            {
                if (inputLine.Contains(" | "))
                {
                    string[] inputArr = inputLine.Split(" | ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = inputArr[0];
                    string user = inputArr[1];
                    if (!forceSides.ContainsKey(side))
                    {
                        forceSides.Add(side, new List<string>());
                    }
                    if (!forceSides.Any(side => side.Value.Contains(user)))
                    {
                        forceSides[side].Add(user);
                    }
                }
                else if (inputLine.Contains(" -> "))
                {
                    string[] inputArr = inputLine.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string user = inputArr[0];
                    string side = inputArr[1];
                    if (!forceSides.Any(side => side.Value.Contains(user)))
                    {
                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides.Add(side, new List<string>());
                        }
                        forceSides[side].Add(user);
                    }
                    else
                    {
                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides.Add(side, new List<string>());
                        }
                        foreach (var value in forceSides.Values)
                        {
                            value.Remove(user);
                        }
                        forceSides[side].Add(user);
                    }
                    Console.WriteLine($"{user} joins the {side} side!");
                }
                inputLine = Console.ReadLine();
            }
            foreach (var side in forceSides.Where(kvp => kvp.Value.Count > 0).OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
