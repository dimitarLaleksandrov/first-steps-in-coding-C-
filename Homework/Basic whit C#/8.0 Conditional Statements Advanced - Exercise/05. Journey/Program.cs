using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "nun";
            string stayIn = "0";
            double spend = 0.0;
            if(budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        spend = budget * 0.30;
                        stayIn = "Camp";
                        break;
                    case "winter":
                        spend = budget * 0.70;
                        stayIn = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            else if(budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        spend = budget * 0.40;
                        stayIn = "Camp";
                        break;
                    case "winter":
                        spend = budget * 0.80;
                        stayIn = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            else if(budget > 1000)
            {
                destination = "Europe";
                switch (season)
                {
                    case "winter":
                    case "summer":
                    spend = budget * 0.90;
                    stayIn = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{stayIn} - {spend:f2}");
        }
    }
}
