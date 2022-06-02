using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class PredicateParty
    {
        static void Main(string[] args)
        {
            List<string> ppl = Console.ReadLine().Split().ToList();
            string cmd = " ";
            while ((cmd = Console.ReadLine()) != "Party!")
            {
                string[] parts = cmd.Split();
                Predicate<string> predicate = Getpredicate(parts);
                if (parts[0] == "Double")
                {                  
                    for (int i = 0; i < ppl.Count; i++)
                    {
                        string person = ppl[i];
                        if (predicate(person))
                        {
                            ppl.Insert(i + 1, person);
                            i++;
                        }
                    }
                }
                else if (parts[0] == "Remove")
                {
                    ppl.RemoveAll(predicate);
                }
            }
            if (ppl.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", ppl)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static Predicate<string> Getpredicate(string[] parts)
        {
            Predicate<string> redusedName = null;
            if (parts[1] == "StartsWith")
            {
                redusedName = name => name.StartsWith(parts[2]);
            }
            else if (parts[1] == "EndsWith")
            {
                redusedName = name => name.EndsWith(parts[2]);
            }
            else if (parts[1] == "Length")
            {
                redusedName = name => name.Length == int.Parse(parts[2]);
            }
            return redusedName;
        } 
    }
}
