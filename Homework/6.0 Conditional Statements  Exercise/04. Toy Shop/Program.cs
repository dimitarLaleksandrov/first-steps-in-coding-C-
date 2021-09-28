using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int toy1 = int.Parse(Console.ReadLine());
            int toy2 = int.Parse(Console.ReadLine());
            int toy3 = int.Parse(Console.ReadLine());
            int toy4 = int.Parse(Console.ReadLine());
            int toy5 = int.Parse(Console.ReadLine());
            int toysNum = toy1 + toy2 + toy3 + toy4 + toy5;
            var toyPrice = (toy1 * 2.60) + (toy2 * 3) + (toy3 * 4.10) + (toy4 * 8.20) + (toy5 * 2);
            if (toysNum >= 50)
            {
                toyPrice = toyPrice - (toyPrice * 0.25);
            }
            double rent = toyPrice * 0.10;
            double moneyLeft = Math.Abs((rent + travelPrice) - toyPrice);
            if (toyPrice >= rent + travelPrice)
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
