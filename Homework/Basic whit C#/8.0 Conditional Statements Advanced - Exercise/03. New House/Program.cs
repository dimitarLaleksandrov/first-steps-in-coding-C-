using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            const double rosesPrice = 5.0;
            const double dahliasPrice = 3.80;
            const double tulipsPrice = 2.80;
            const double narcissusPrice = 3.0;
            const double gladiolusPrice = 2.50;
            string type = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;
            switch(type)
            {
                case"Roses":
                    if(num > 80)
                    {
                        price -= num * rosesPrice * 0.10;
                    }
                    price += num * rosesPrice;
                    break;
                case"Dahlias":
                    if(num > 90)
                    {
                        price -= num * dahliasPrice * 0.15;
                    }
                    price += num * dahliasPrice;
                    break;
                case"Tulips":
                    if(num > 80)
                    {
                        price -= num * tulipsPrice * 0.15;
                    }
                    price += num * tulipsPrice;
                    break;
                case"Narcissus":
                    if(num < 120)
                    {
                        price += num * narcissusPrice * 0.15;
                    }
                    price += num * narcissusPrice;
                    break;
                case"Gladiolus":
                    if(num < 80)
                    {
                        price += num * gladiolusPrice * 0.20;
                    }
                    price += num * gladiolusPrice;
                    break;
            }
            if(budget >= price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {num} {type} and {moneyLeft:f2} leva left.");
            }
            else if(budget < price)
            {
                double needMoreMoney = price - budget;
                Console.WriteLine($"Not enough money, you need {needMoreMoney:f2} leva more.");
            }
        }
    }
}