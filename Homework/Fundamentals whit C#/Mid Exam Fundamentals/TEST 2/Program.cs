using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeTipes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            int commands = int.Parse(Console.ReadLine());
            for (int i = 1; i <= commands; i++)
            {
                List<string> command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (command[0])
                {
                    case "Include":
                        coffeeTipes.Add(command[1]);
                        break;
                    case "Remove":
                        switch (command[1])
                        {
                            case "first":
                                int numOfCoffeesAtFirst = int.Parse(command[2]);
                                if (numOfCoffeesAtFirst > coffeeTipes.Count)
                                {
                                    break;
                                }
                                for (int j = 1; j <= numOfCoffeesAtFirst; j++)
                                {
                                    coffeeTipes.RemoveAt(0);
                                }
                                break;
                            case "last":
                                int numOfCoffeesAtLast = int.Parse(command[2]);
                                if (numOfCoffeesAtLast > coffeeTipes.Count)
                                {
                                    break;
                                }
                                for (int k = 1; k <= numOfCoffeesAtLast; k++)
                                {
                                    coffeeTipes.RemoveAt(coffeeTipes.Count - 1);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Prefer":
                        int firstCoffee = int.Parse(command[1]);
                        int secondCoffee = int.Parse(command[2]);
                        if (firstCoffee > coffeeTipes.Count || secondCoffee > coffeeTipes.Count || (firstCoffee < 0 || secondCoffee < 0))
                        {
                            break;
                        }
                        var coffee = coffeeTipes[firstCoffee];
                        coffeeTipes[firstCoffee] = coffeeTipes[secondCoffee];
                        coffeeTipes[secondCoffee] = coffee;
                        break;
                    case "Reverse":
                        coffeeTipes.Reverse();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeeTipes));
        }
    }
}
