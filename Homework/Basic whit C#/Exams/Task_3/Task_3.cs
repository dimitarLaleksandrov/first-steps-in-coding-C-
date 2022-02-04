using System;

namespace Task_3
{
    class Task_3
    {
        static void Main(string[] args)
        {
            int numOfDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();
            string place = Console.ReadLine();
            double price = 0;
            double charity = 0;
            switch (place)
            {
                case "Bulgaria":
                   
                    switch (seson)
                    {
                        case "summer":
                            price = (numOfDancers * points) - ((numOfDancers * points) * 0.05);
                            charity = price * 0.75;
                            break;
                        case "winter":
                            price = (numOfDancers * points) - ((numOfDancers * points) * 0.08);
                            charity = price * 0.75;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Abroad":
                   
                    switch (seson)
                    {
                        case "summer":
                            price = ((numOfDancers * points) + ((numOfDancers * points) * 0.50) - (((numOfDancers * points) + ((numOfDancers * points) * 0.50)) * 0.10));
                            charity = price * 0.75;
                            break;
                        case "winter":
                            price = ((numOfDancers * points) + ((numOfDancers * points) * 0.50) - (((numOfDancers * points) + ((numOfDancers * points) * 0.50)) * 0.15));
                            charity = price * 0.75;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            double dancerssum = (price - charity) / numOfDancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {dancerssum:f2}");
        }
    }
}
