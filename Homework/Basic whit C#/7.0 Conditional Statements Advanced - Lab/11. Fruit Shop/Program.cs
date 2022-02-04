using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            decimal price = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50m;
                            break;
                        case "apple":
                            price = 1.20m;
                            break;
                        case "orange":
                            price = 0.85m;
                            break;
                        case "grapefruit":
                            price = 1.45m;
                            break;
                        case "kiwi":
                            price = 2.70m;
                            break;
                        case "pineapple":
                            price = 5.50m;
                            break;
                        case "grapes":
                            price = 3.85m;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70m;
                            break;
                        case "apple":
                            price = 1.25m;
                            break;
                        case "orange":
                            price = 0.90m;
                            break;
                        case "grapefruit":
                            price = 1.60m;
                            break;
                        case "kiwi":
                            price = 3.00m;
                            break;
                        case "pineapple":
                            price = 5.60m;
                            break;
                        case "grapes":
                            price = 4.20m;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (price != 0)
            {
                Console.WriteLine($"{((decimal)quantity) * price:f2}");
            }
        }
    }
}
