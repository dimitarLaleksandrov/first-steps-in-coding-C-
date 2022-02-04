using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal outFallFore = 39.99m;
            const decimal csOG = 15.99m;
            const decimal zplinterZell = 19.99m;
            const decimal honoredTwo = 59.99m;
            const decimal roverWatch = 29.99m;
            const decimal originalRoverWatch = 39.99m;
            decimal balans = decimal.Parse(Console.ReadLine());
            string input = string.Empty;
            decimal money = 0m;
            decimal totalSpend = 0m;
            money = balans;
            while (input != "Game Time")
            {
                string gameName = Console.ReadLine();
                switch (gameName)
                {
                    case "OutFall 4":
                        if (money >= outFallFore)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            money -= outFallFore;
                            totalSpend += outFallFore;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (money >= csOG)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            money -= csOG;
                            totalSpend += csOG;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (money >= zplinterZell)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            money -= zplinterZell;
                            totalSpend += zplinterZell;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (money >= honoredTwo)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            money -= honoredTwo;
                            totalSpend += honoredTwo;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive!");
                        }
                        break;
                    case "RoverWatch":
                        if (money >= roverWatch)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            money -= roverWatch;
                            totalSpend += roverWatch;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");                           
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (money >= originalRoverWatch)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            money -= originalRoverWatch;
                            totalSpend += originalRoverWatch;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");                           
                        }
                        break;
                    default:
                        break;
                }
                if (gameName != "OutFall 4" && gameName != "CS: OG" && gameName != "Zplinter Zell" && gameName != "Honored 2" && gameName != "RoverWatch" && gameName != "RoverWatch Origins Edition" && gameName != "Game Time")
                    {
                         Console.WriteLine("Not Found");
                    }  
                if (money == 0)
                    {
                        Console.WriteLine("Out of money!");
                          break;
                    }
                input = gameName;
            }
            decimal remainingMoney = balans - totalSpend;
            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${remainingMoney:f2}");
            }
        }
    }
}
