using System;

namespace _0._3_Vacation_vol_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;
            while (ownedMoney < neededMoney && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine(" You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
