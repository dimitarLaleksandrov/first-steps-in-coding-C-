using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Result(product, quantity);
        }
        static void Result(string product, int quantity)
        {
            decimal price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50m;
                    break;
                 case "water":
                    price = 1.00m;
                    break;
                case "coke":
                    price = 1.40m;
                    break;
                case "snacks":
                    price = 2.00m;
                    break;
                default:
                    break;
            }
            decimal allPrice = price * quantity;
            Console.WriteLine(allPrice);
        }
    }
}
