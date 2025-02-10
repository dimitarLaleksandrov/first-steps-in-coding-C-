using System.Diagnostics.Metrics;
using System;

namespace Programming_Basics_Tast_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budgetTheyHave = decimal.Parse(Console.ReadLine()); 
            int nights = int.Parse(Console.ReadLine());
            decimal nightPrice = decimal.Parse(Console.ReadLine());
            int additionalCostsInProcent = int.Parse(Console.ReadLine());
            const decimal discountOnThePrice = (decimal)0.05;
            const int nightForSescount = 7;
            decimal descount = 0;
            if (nights > nightForSescount)
            {
                descount = nightPrice * discountOnThePrice;
               
            }
            else
            {
                descount = 0;
            }
            nightPrice = nightPrice - descount;
            decimal allNights = nightPrice * nights;
            decimal extraCosts = budgetTheyHave * additionalCostsInProcent / 100;
            decimal ifTheMoneyAreEnough = allNights + extraCosts;
            if (ifTheMoneyAreEnough <= budgetTheyHave)
            {
                decimal sufficientMoney = Math.Round(budgetTheyHave - ifTheMoneyAreEnough, 2);
                Console.WriteLine($"Ivanovi will be left with {sufficientMoney.ToString("f2")} leva after vacation.");
            }
            else
            {
                decimal moneyNeedet = Math.Round(ifTheMoneyAreEnough - budgetTheyHave, 2);
                Console.WriteLine($"{moneyNeedet.ToString("f2")} leva needed.");
            }
        }
    }
}
