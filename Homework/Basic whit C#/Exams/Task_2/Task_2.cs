using System;

namespace Task_2
{
    class Task_2
    {
        static void Main(string[] args)
        {
            const int daysLeft = 5;
            decimal dailyMoney = decimal.Parse(Console.ReadLine());
            decimal profit = decimal.Parse(Console.ReadLine());
            decimal allSpend = decimal.Parse(Console.ReadLine());
            decimal presentPrice = decimal.Parse(Console.ReadLine());
            decimal terezaSave = dailyMoney * daysLeft;
            decimal moneySave = profit * daysLeft;
            decimal allMoney = (terezaSave + moneySave) - allSpend;
            if (allMoney >= presentPrice)
            {
                Console.WriteLine($"Profit: {allMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                decimal notEnofSum = presentPrice - allMoney;
                Console.WriteLine($"Insufficient money: {notEnofSum} BGN.");
            }
        }
    }
}
