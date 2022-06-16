using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }
                string personName = input[0];
                int personAge = int.Parse(input[1]);
                string personTown = input[2];
                persons.Add(new Person(personName, personAge, personTown));
            }
            var index = int.Parse(Console.ReadLine()) - 1;
            var equal = 0;
            var notequal = 0;
            foreach (var person in persons)
            {
                if (persons[index].CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    notequal++;
                }
            }
            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notequal} {persons.Count}");
            }
        }
    }
}
