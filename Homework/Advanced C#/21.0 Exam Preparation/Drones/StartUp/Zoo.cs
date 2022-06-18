using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StartUp
{
    public class Zoo
    {
        public Zoo (string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.Animal = new List<Animal>();
        }
        List<Animal> animal;
        private string name;
        private int capacity;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public List<Animal> Animal
        {
            get { return animal; }
            set { animal = value; }
        }
        public string AddAnimal(Animal animal)
        {
            int animalsCount = 0;
            if (animal.Species == null && animal.Species == string.Empty)
            {
                return $"Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return $"Invalid animal diet.";
            }
            if (this.Capacity < animalsCount)
            {
                return $"The zoo is full.";
            }
            else
            {
                this.Animal.Add(animal);
                animalsCount++;
                return $"Successfully added {animal.Species} to the zoo.";
            }
        }

        public Animal GetAnimalByWeight(double weight)
        {
            return this.Animal.FirstOrDefault(a => a.Weight == weight);
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animals = this.Animal.Where(anilal => anilal.Diet == diet).ToList();
            return animals;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int animalCount = 0;
            var foundAnimals = this.Animal.Where(a => a.Length >= minimumLength).Where(a => a.Length <= maximumLength);
            animalCount = foundAnimals.Count();
            return $"There are {animalCount} animals with a length between {minimumLength} and {maximumLength} meters.";
        }

        internal int RemoveAnimals(string species)
        {
            int removeAnimalsCounter = this.Animal.RemoveAll(a => a.Species == species);
            return removeAnimalsCounter;
        }
    }
}
