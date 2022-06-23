using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public Clinic(int capasity)
        {
            Capacity = capasity;
            Pets = new List<Pet>(capasity);
        }
        private List<Pet> pets;
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public List<Pet> Pets
        {
            get { return pets; }
            set { pets = value; }
        }

        public int Count { get { return pets.Count; } }


        public bool Remove(string name)
        {
            bool isPetExist = false;
            var pets = new List<Pet>(Pets);
            foreach (var pet in pets)
            {
                if(pet.Name == name)
                {
                    Pets.Remove(pet);
                    isPetExist = true;
                }
            }
            return isPetExist;
        }

        public Pet GetOldestPet()
        {
            Pet oldestPet = new Pet(null, 0, null);
            foreach (var pet in Pets)
            {
                if(pet.Age > oldestPet.Age)
                {
                    oldestPet = pet;
                }
            }
            return oldestPet;
        }

        public string GetStatistics()
        {
            var text = new StringBuilder();
            text.AppendLine($"The clinic has the following patients:");
            foreach (var pet in Pets)
            {
                text.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return text.ToString();
        }
        public Pet GetPet(string name, string owner)
        {
            foreach (var p in Pets)
            {
                if(p.Owner == owner && p.Name == name)
                {
                    return p;
                }
            }
            return null;
        }

        public void Add(Pet pet)
        {
            
            if(Pets.Count < Capacity)
            {
                Pets.Add(pet);    
            }      
        }
    }
}
