using System;
using System.Collections.Generic;

namespace _04._Opinion_Poll
{
    internal class OpinionPoll
    {
        static void Main(string[] args)
        {
            int pplNumber = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 1; i <= pplNumber; i++)
            {
                string[] ppls = Console.ReadLine().Split();
                string name = ppls[0];
                int age = int.Parse(ppls[1]);
                Person person = new Person(name, age);
                family.AddMembe(person);
            }   
        }
    }
}
