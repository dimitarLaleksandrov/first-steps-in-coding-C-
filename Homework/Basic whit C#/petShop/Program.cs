using System;

namespace petShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            var priceOfDogFood = dogFood * 2.50;
            var priceOfCatFood = catFood * 4;
            var endSum = priceOfDogFood + priceOfCatFood;
            Console.WriteLine(endSum + " lv.");
        }
    }
}
