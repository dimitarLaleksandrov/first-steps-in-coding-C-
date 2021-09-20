using System;

namespace _04._Toy_Shop_level_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double dollPrice = 3.0;
            const double teddyBeraPrice = 4.10;
            const double minionPrice = 8.20;
            const double trucksPrice = 2.0;
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int teddyBear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int toysNum = puzzle + doll + teddyBear + minions + trucks;
            double toysPrice = (puzzle * puzzlePrice) + (doll * dollPrice) + (teddyBear * teddyBeraPrice) + (minions * minionPrice) + (trucks * trucksPrice);
            if(toysNum >= 50)
            {
                toysPrice = toysPrice - (toysPrice * 0.25);
            }
            double rent = toysPrice * 0.10;
            double moneyLeft = Math.Abs(rent + travelPrice - toysPrice);
            if (toysPrice >= rent + travelPrice)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyLeft:f2} lv needed.");
            }
        }
    }
}
