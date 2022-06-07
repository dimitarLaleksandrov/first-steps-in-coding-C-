using DefiningClasses;
using System;

namespace DefineClassPerson
{
    internal class DefiningClasses
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person secondPerson = new Person("Peter", 20);
            person.Name = "Jose";
            person.Age = 41;
            Console.WriteLine(person.Age);
        }
    }
}
