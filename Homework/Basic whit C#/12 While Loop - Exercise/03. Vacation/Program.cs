using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyNeed = decimal.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());
            int dayCounter = 0;
            decimal spendCounter = 0m;
            while (spendCounter != 5)
            {
                string action = Console.ReadLine();
                decimal actionMoney = decimal.Parse(Console.ReadLine());
                dayCounter++;
                if (action == "spend")
                {
                    spendCounter++;
                    if (actionMoney > money)
                    {
                        money = 0;                     
                    }
                    else
                    {
                        money -= actionMoney;
                    }
                }
                else if (action == "save")
                {
                    money += actionMoney;
                    spendCounter = 0;
                }
                if (money >= moneyNeed)
                {
                    Console.WriteLine($"You saved the money for {dayCounter} days.");
                    break;
                }
            }
            if (spendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{dayCounter}");
            }
        }     
    }
}
