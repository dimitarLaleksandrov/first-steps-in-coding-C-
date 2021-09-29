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
                if(season == "summer")
                {
                    spend = budget * 0.30;
                    stayIn = "Camp";
                }
                else if(season == "winter")
                {
                    spend = budget * 0.70;
                    stayIn = "Hotel";
                }
            }
            else if(budget <= 1000)
            {
                destination = "Balkans";
                if(season == "summer")
                {
                    spend = budget * 0.40;
                    stayIn = "Camp";
                }
                else if(season == "winter")
                {
                    spend = budget * 0.80;
                    stayIn = "Hotel";
                }
            }
            else if(budget > 1000)
            {
                destination = "Europe";
                if(season == "winter" || season == "summer")
                {
                    spend = budget * 0.90;
                    stayIn = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{stayIn} - {spend:f2}");
        }
    }
}
