using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointOfActor = double.Parse(Console.ReadLine());
            int evaluators = int.Parse(Console.ReadLine());
            double sumPoint = pointOfActor;
            bool actorFound = false;
            for (int i = 1; i <= evaluators; i++)
            {
                string nameOfEvaluator = Console.ReadLine();
                double pointsjury = double.Parse(Console.ReadLine());
                double momentsPoints = (nameOfEvaluator.Length * pointsjury) / 2;
                sumPoint += momentsPoints;
                if (sumPoint >= 1250.50)
                {
                    actorFound = true;
                    break;
                }
            }
            if (actorFound)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sumPoint:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.50 - sumPoint:f1} more!");
            }
        }
    }
}
