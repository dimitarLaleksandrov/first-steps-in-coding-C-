using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int vCardsNum = int.Parse(Console.ReadLine());
            int processorsNum = int.Parse(Console.ReadLine());
            int ramNum = int.Parse(Console.ReadLine());
            const int videoCards = 250;
            int cardsPrice = vCardsNum * videoCards;
            double processors = cardsPrice * 0.35;
            double ram = cardsPrice * 0.10;
            double allPrice = cardsPrice + (processors * processorsNum) + (ram * ramNum);
            if(vCardsNum > processorsNum)
            {
                allPrice = allPrice- (allPrice * 0.15);
            }
            if(budget >= allPrice)
            {
                Console.WriteLine($"You have {budget - allPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {allPrice - budget:f2} leva more!");
            }
        }
    }
}
