using System;

namespace Turist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal buget = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            decimal allPrice = 0m;
            int productCounter = 0;
            while (input != "Stop" && allPrice <= buget)
            {

                productCounter++;
                decimal priceOfProdukt = decimal.Parse(Console.ReadLine());
                if (allPrice <= buget)
                {                   
                    if (productCounter % 3 == 0 && productCounter >= 3)
                    {
                        priceOfProdukt *= 0.50m;
                    }
                    allPrice += priceOfProdukt;
                }
                if (allPrice <= buget)
                {
                    input = Console.ReadLine();
                }  
            }
            if (input == "Stop")
            {
                Console.WriteLine($"You bought {productCounter} products for {allPrice:f2} leva.");
            }
            decimal moneyNeed = allPrice - buget;
            if (allPrice > buget)
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {moneyNeed:f2} leva!");
            }
        }
    }
}
