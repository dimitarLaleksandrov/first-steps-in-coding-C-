using System;

namespace Exam_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodForTheDogy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double foodCounter = 0;
            double dogyFood = foodForTheDogy * 1000;
            if (foodCounter <= dogyFood)
            {
                
                while (input != "Adopted")
                {
                    int food = int.Parse(input);
                    foodCounter += food;
                    input = Console.ReadLine();
                }     
            }
            if (dogyFood >= foodCounter)
            {
                double restFood = (foodForTheDogy * 1000) - foodCounter;
                Console.WriteLine($"Food is enough! Leftovers: {restFood} grams.");
            }
            else if (foodCounter > dogyFood)
            {
                double foodNeed = foodCounter - (foodForTheDogy * 1000);
                Console.WriteLine($"Food is not enough. You need {foodNeed} grams more.");
            }
           
        }
    }
}
