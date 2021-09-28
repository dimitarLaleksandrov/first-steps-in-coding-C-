using System;

namespace foodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vege = int.Parse(Console.ReadLine());
            var chickenPrice = chicken * 10.35;
            var fishPrice = fish * 12.40;
            var vegePrice = vege * 8.15;
            var dessertPrice = (fishPrice + vegePrice + chickenPrice) * 0.20;
            var delivery = 2.50;
            Console.WriteLine(chickenPrice + fishPrice + vegePrice + dessertPrice + delivery);
        }
    }
}
