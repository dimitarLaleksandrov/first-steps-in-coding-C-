using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal tenCent = 0.1m;
            const decimal twentyCent = 0.2m;
            const decimal fifteyCent = 0.5m;
            const decimal oneDolar = 1m;
            const decimal twoDolars = 2m;
            string input = Console.ReadLine();
            decimal moneyCounter = 0;
            while(input != "Start")
            {
                decimal coin = decimal.Parse(input);
                if (coin != tenCent && coin != twentyCent && coin != fifteyCent && coin != oneDolar && coin != twoDolars)
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                else
                {
                    moneyCounter += coin;
                }
                input = Console.ReadLine();
            }
            decimal allMoney = moneyCounter;
            decimal moneyLeft = allMoney;
            const decimal nuts = 2.0m;
            const decimal water = 0.7m;
            const decimal crisps = 1.5m;
            const decimal soda = 0.8m;
            const decimal coke = 1m;
            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product == "Nuts" && moneyLeft >= nuts)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    moneyLeft -= nuts;
                }
               else if (product == "Water" && moneyLeft >= water)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    moneyLeft -= water;
                }
                else if (product == "Crisps" && moneyLeft >= crisps)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    moneyLeft -= crisps;
                }
                else if (product == "Soda" && moneyLeft >= soda)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    moneyLeft -= soda;
                }
                else if (product == "Coke" && moneyLeft >= coke)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    moneyLeft -= coke;
                }
                else if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {moneyLeft:f2}");
        }
    }
}
