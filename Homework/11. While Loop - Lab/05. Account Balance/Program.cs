using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            decimal sum = 0m;
            while (money != "NoMoreMoney")
            {
                decimal amount = decimal.Parse(money);            
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                money = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
