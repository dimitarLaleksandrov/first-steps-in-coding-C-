using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class PredicateForNames
    {
        static void Main(string[] args)
        {
            int lentNum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Predicate<string> redusedNames = list => list.Length <= lentNum;
            List<string> LentedNames = new List<string>();
            foreach (string name in names)
            {
                if (redusedNames(name))
                {
                    LentedNames.Add(name);
                }
            }
            Console.WriteLine(string.Join("\n", LentedNames));
        }
    }
}
