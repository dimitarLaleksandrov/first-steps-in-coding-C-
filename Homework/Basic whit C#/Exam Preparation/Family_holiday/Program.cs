using System;

namespace Family_holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int nightStays = int.Parse(Console.ReadLine());
            decimal priceOfNIght = decimal.Parse(Console.ReadLine());
            decimal extrasSpendsInProcent = decimal.Parse(Console.ReadLine());
            if (nightStays > 7)
            {
                priceOfNIght = priceOfNIght - (priceOfNIght * 0.05m);
            }
            decimal allNIghtPrice = priceOfNIght * nightStays;
            decimal extraSpends = extrasSpendsInProcent / 100 * budget;
            decimal moneyNeed = allNIghtPrice + extraSpends;
            if (moneyNeed <= budget)
            {
                decimal moneyLeft = budget - moneyNeed;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else if (budget < moneyNeed)
            {
                decimal moneyNeedToGoal = moneyNeed - budget;
                Console.WriteLine($"{moneyNeedToGoal:f2} leva needed.");
            }
        }
    }
}
