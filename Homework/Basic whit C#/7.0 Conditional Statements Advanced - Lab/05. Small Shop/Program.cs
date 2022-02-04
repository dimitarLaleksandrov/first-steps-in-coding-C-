using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            decimal price = 0.0m;
            switch (city)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.50m;
                            break;
                        case "water":
                            price = 0.80m;
                            break;
                        case "beer":
                            price = 1.20m;
                            break;
                        case "sweets":
                            price = 1.45m;
                            break;
                        case "peanuts":
                            price = 1.60m;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.40m;
                            break;
                        case "water":
                            price = 0.70m;
                            break;
                        case "beer":
                            price = 1.15m;
                            break;
                        case "sweets":
                            price = 1.30m;
                            break;
                        case "peanuts":
                            price = 1.50m;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.45m;
                            break;
                        case "water":
                            price = 0.70m;
                            break;
                        case "beer":
                            price = 1.10m;
                            break;
                        case "sweets":
                            price = 1.35m;
                            break;
                        case "peanuts":
                            price = 1.55m;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            decimal allPrice = ((decimal)quantity) * price;
            Console.WriteLine(allPrice);
        }
    }
}
