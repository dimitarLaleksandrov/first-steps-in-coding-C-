using System.Collections.Generic;
using System;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "Beast!")
            {
                string type = cmd;
                string[] inputs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputs[0];
                int age = int.Parse(inputs[1]);
                string gender = inputs[2];
                Animal animal = null;
                if(type == "Cat")
                {
                    animal = new Cat(name, age, gender);
                }
                else if (type == "Dog")  
                {
                    animal = new Dog(name, age, gender);
                }
                else if (type == "Frog")
                {
                    animal = new Frog(name, age, gender);
                }
                else if (type == "Kittens")
                {
                    animal = new Kittens(name, age);
                }
                else if (type == "Tomcat")
                {
                    animal = new Tomcat(name, age);
                }
                else
                {
                    throw new InvalidOperationException("Invalid animal!");
                }
                animals.Add(animal);
            }
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
