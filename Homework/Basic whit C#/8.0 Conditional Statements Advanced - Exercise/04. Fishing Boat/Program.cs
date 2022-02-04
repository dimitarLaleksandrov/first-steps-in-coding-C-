using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceS = 3000;
            const double priceSum = 4200;
            const double priceA = 4200;
            const double priceW = 2600;
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double shipRent = 0.0;
            switch(season)
            {
                case"Spring":
                    shipRent = priceS;
                        break;
                case "Summer":
                    shipRent = priceSum;
                    break;
                case "Autumn":
                    shipRent = priceA;
                    break;
                case "Winter":
                    shipRent = priceW;
                    break;
            }
            if(fishermen <= 6)
            {
                shipRent -= shipRent * 0.10;
            }
            else if(fishermen >= 7 && fishermen <= 11)
            {
                shipRent -= shipRent * 0.15;
            }
            else if(fishermen >= 12)
            {
                shipRent -= shipRent * 0.25;
            }
            if(fishermen % 2 == 0 && season != "Autumn")
            {
                shipRent -= shipRent * 0.05;
            }
            if(groupBudget >= shipRent)
            {
                double moneyLeft = groupBudget - shipRent;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if(groupBudget < shipRent)
            {
                double moneyNeed = shipRent - groupBudget;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
        }
    }
}
