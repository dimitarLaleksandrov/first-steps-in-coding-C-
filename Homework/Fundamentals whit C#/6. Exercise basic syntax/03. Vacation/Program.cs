using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            decimal priceOfSingelPerson = 0m;
            decimal totalPrice = 0m;
            switch (typeOfGroup)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            priceOfSingelPerson = 8.45m;
                            break;
                        case "Saturday":
                            priceOfSingelPerson = 9.80m;
                            break;
                        case "Sunday":
                            priceOfSingelPerson = 10.46m;
                            break;
                        default:
                            break;
                    }
                    totalPrice = priceOfSingelPerson * groupNum;
                    if (groupNum >= 30)
                    {
                        totalPrice = priceOfSingelPerson * groupNum - (((priceOfSingelPerson * groupNum ) * 15 ) / 100);
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            priceOfSingelPerson = 10.90m;
                            break;
                        case "Saturday":
                            priceOfSingelPerson = 15.60m;
                            break;
                        case "Sunday":
                            priceOfSingelPerson = 16m;
                            break;
                        default:
                            break;
                    }
                    totalPrice = priceOfSingelPerson * groupNum;
                    if (groupNum >= 100)
                    {
                        totalPrice = priceOfSingelPerson * groupNum - (10 * priceOfSingelPerson);
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            priceOfSingelPerson = 15m;
                            break;
                        case "Saturday":
                            priceOfSingelPerson = 20m;
                            break;
                        case "Sunday":
                            priceOfSingelPerson = 22.50m;
                            break;
                        default:
                            break;
                    }
                    totalPrice = priceOfSingelPerson * groupNum;
                    if (groupNum >= 10 && groupNum < 21)
                    {
                        totalPrice = priceOfSingelPerson * groupNum - (((priceOfSingelPerson * groupNum) * 5) / 100);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
