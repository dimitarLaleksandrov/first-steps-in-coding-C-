using System;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int litersNeed = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double wine = vineyard * 0.40;
            double wineHave = wine * grapes;
            double litersWine = Math.Floor(wineHave / 2.5);
            if(litersWine > litersNeed)
            {
                var remainingWine = Math.Ceiling(litersWine - litersNeed);
                var wineForWorkers = Math.Ceiling(remainingWine / workers);
                Console.WriteLine($"Good harvest this year! Total wine:{litersWine} liters.");
                Console.WriteLine($"{remainingWine} liters left -> {wineForWorkers} liters per person.");
            }
            else
            {
                var moreWine = Math.Floor(litersNeed - litersWine);
                Console.WriteLine($"It will be a tough winter! More {moreWine} liters wine needed.");
            }
        }
    }
}
