using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static List<int> OnliPozitiveNumbers(List<int> numbers)
        {
            List<int> num = Console.ReadLine().Split().Select(int.Parse).Where(n => n >= 0).Reverse().ToList();
            return num;
        }
        static void StringListManipulation(string[] commands)
        {
            var books = Console.ReadLine().Split("&").ToList();
            var commandLine = Console.ReadLine().Split("|");
            var command = commandLine[0].Trim();
            var booksToPrint = new List<string>();
            while (command != "Done")
            {
                switch (command)
                {
                    case "Add Book":
                        {
                            var bookName = commandLine[1].Trim();
                            if (books.Contains(bookName))
                            {
                                break;
                            }
                            books.Insert(0, bookName);
                            break;
                        }
                    case "Take Book":
                        {
                            var bookName = commandLine[1].Trim();
                            if (!books.Contains(bookName))
                            {
                                break;
                            }
                            var index = books.IndexOf(bookName);
                            books.RemoveAt(index);
                            break;
                        }
                    case "Swap Books":
                        {
                            var book1 = commandLine[1].Trim();
                            var book2 = commandLine[2].Trim();
                            if (books.Contains(book1) && books.Contains(book1))
                            {
                                var index1 = books.IndexOf(book1);
                                var index2 = books.IndexOf(book2);
                                books[index1] = book2;
                                books[index2] = book1;
                                break;
                            }
                            break;
                        }
                    case "Insert Book":
                        {
                            var bookName = commandLine[1].Trim();
                            if (books.Contains(bookName))
                            {
                                break;
                            }
                            books.Add(bookName);
                            break;
                        }
                    case "Check Book":
                        {
                            var index = int.Parse(commandLine[1].Trim());
                            if (index < 0 || index > books.Count() - 1)
                            {
                                break;
                            }
                            booksToPrint.Add(books[index]);
                            Console.WriteLine(booksToPrint);
                            break;
                        }
                    default:
                        break;
                }
                commandLine = Console.ReadLine().Split("|");
                command = commandLine[0].Trim();
            }
        }
        static void ListManipulationBasics(List<int> numbers, string[] command)
        {
            bool anyChangesMade = false;
            switch (command[0])
            {
                case "Add":
                    numbers.Add(int.Parse(command[1]));
                    anyChangesMade = true;
                    break;
                case "Remove":
                    numbers.Remove(int.Parse(command[1]));
                    anyChangesMade = true;
                    break;
                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(command[1]));
                    anyChangesMade = true;
                    break;
                case "Insert":
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    anyChangesMade = true;
                    break;
                case "Contains":
                    Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                    break;
                case "PrintEven":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                    break;
                case "PrintOdd":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 1)));
                    break;
                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;
                case "Filter":
                    if (command[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(command[2]))));
                    }
                    else if (command[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(command[2]))));
                    }
                    else if (command[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(command[2]))));
                    }
                    else if (command[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(command[2]))));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
