namespace Programming_Basics_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal movieBudget = decimal.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            decimal pricePerDay = 0;

            switch (destination)
            {
                case "Dubai":
                    switch (season)
                    {
                        case "Summer":
                            pricePerDay = 40000;
                            break;

                        case "Winter":
                            pricePerDay = 45000;
                            break;
                        default:
                            break;
                    }
                    break;

                case "Sofia":
                    switch (season)
                    {
                        case "Summer":
                            pricePerDay = 12500;
                            break;

                        case "Winter":
                            pricePerDay = 17000;
                            break;
                        default:
                            break;
                    }
                    break;

                case "London":
                    switch (season)
                    {
                        case "Summer":
                            pricePerDay = 20250;
                            break;

                        case "Winter":
                            pricePerDay = 24000;
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

            decimal allDaysPrice = pricePerDay * days;
            if (destination == "Sofia")
            {
                allDaysPrice = allDaysPrice + (allDaysPrice * (decimal)0.25);
            }
            else if (destination == "Dubai")
            {
                allDaysPrice = allDaysPrice - (allDaysPrice * (decimal)0.30);
            }
            if (allDaysPrice <= movieBudget)
            {
                decimal budgetBalance = movieBudget - allDaysPrice;
                Console.WriteLine($"The budget for the movie is enough! We have {budgetBalance.ToString("f2")} leva left!");
            }
            else             
            {
                decimal budgetBalance = allDaysPrice - movieBudget;
                Console.WriteLine($"The director needs {budgetBalance.ToString("f2")} leva more!");
            }
        }
    }
}
