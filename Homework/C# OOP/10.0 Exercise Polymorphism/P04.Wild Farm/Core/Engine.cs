using System;
using System.Collections.Generic;
using System.Text;
using P04.WildFarm.Models.Animals;
using P04.WildFarm.Facroris.Intercafes;
using P04.WildFarm.Models.Foods;
using P04.WildFarm.Facroris;
using P04.WildFarm.Exeptions;

namespace P04.WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly ICollection<Animal> animals;
        private readonly IFoodfactory foodFactory;
        private readonly IAnimaleFactory animaleFactory;
        private Engine()
        {
            this.animals = new List<Animal>();
        }
        public Engine(IAnimaleFactory animaleFactory, IFoodfactory foodfactory) : this()
        {
            this.animaleFactory = animaleFactory;
            this.foodFactory = foodfactory;
        }
        public void Start()
        {
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] animalArguments = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string[] foodArguments = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Animal animal = null;
                    if (animalArguments.Length == 4)
                    {
                        string animalType = animalArguments[0];
                        string animalName = animalArguments[1];
                        double weight = double.Parse(animalArguments[2]);
                        string thirdparam = animalArguments[3];
                        animal = this.animaleFactory.CreateAnimal(animalType, animalName, weight, thirdparam);
                    }
                    else if (animalArguments.Length == 5)
                    {
                        string animalType = animalArguments[0];
                        string animalName = animalArguments[1];
                        double weight = double.Parse(animalArguments[2]);
                        string thirdparam = animalArguments[3];
                        string forthparam = animalArguments[4];
                        animal = this.animaleFactory.CreateAnimal(animalType, animalName, weight, thirdparam, forthparam);
                    }
                    Food food = this.foodFactory.CreateFood(foodArguments[0], int.Parse(foodArguments[1]));
                    Console.WriteLine(animal.ProduceSounde());
                    this.animals.Add(animal);
                    animal.Eat(food);
                }
                catch (InvalidFactoriTypeExeption ifte)
                {
                  Console.WriteLine(ifte.Message);
                }
                catch(FoodNotPrefurdExeption fnpe)
                {
                    Console.WriteLine(fnpe.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
