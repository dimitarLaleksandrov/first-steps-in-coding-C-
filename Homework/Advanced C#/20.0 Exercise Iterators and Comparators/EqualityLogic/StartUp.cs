using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var sortedSet = new SortedSet<Person>();
            var hasSet = new HashSet<Person>();
            var lines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lines; i++)
            {
                var input = Console.ReadLine().Split();
                var person = new Person(input[0], int.Parse(input[1]));
                sortedSet.Add(person);
                hasSet.Add(person);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hasSet.Count);
        }
    }
}
