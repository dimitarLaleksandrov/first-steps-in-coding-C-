using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string comand = string.Empty;
            bool haveChainges = false;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] input = comand.Split();
                switch (input[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(input[1]);
                        numbers.Add(numberToAdd);
                        haveChainges = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(input[1]);
                        numbers.Remove(numberToRemove);
                        haveChainges = true;
                        break;
                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(input[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        haveChainges = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(input[1]);
                        int indexToInsert = int.Parse(input[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        haveChainges = true;
                        break;
                    default:
                        break;
                }
                switch (input[0])
                {
                    case "Contains":
                        int ifContains = int.Parse(input[1]);
                        if (numbers.Contains(ifContains))
                        {
                            Console.WriteLine("Yes");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                            break;
                        }
                    case "PrintEven":
                        List<int> evenNums = numbers.FindAll(num => num % 2 == 0);
                        Console.WriteLine(string.Join(" ", evenNums));
                        break;
                    case "PrintOdd":
                        List<int> oddNums = numbers.FindAll(num => num % 2 != 0);
                        Console.WriteLine(string.Join(" ", oddNums));
                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        switch (input[1])
                        {
                            case "<":
                                int isItLess = int.Parse(input[2]);
                                List<int> resultIsItLess = numbers.FindAll(num => num < isItLess);
                                Console.WriteLine(string.Join(" ", resultIsItLess));
                                break;
                            case ">":
                                int isItBigger = int.Parse(input[2]);
                                List<int> resultIsItBigger = numbers.FindAll(num => num > isItBigger);
                                Console.WriteLine(string.Join(" ", resultIsItBigger));
                                break;
                            case "<=":
                                int lessOrЕqual = int.Parse(input[2]);
                                List<int> resultLessOrEqual = numbers.FindAll(num => num <= lessOrЕqual);
                                Console.WriteLine(string.Join(" ", resultLessOrEqual));
                                break;
                            case ">=":
                                int biggerOrЕqual = int.Parse(input[2]);
                                List<int> resultBiggerOrEqual = numbers.FindAll(num => num >= biggerOrЕqual);
                                Console.WriteLine(string.Join(" ", resultBiggerOrEqual));
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            if (haveChainges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
