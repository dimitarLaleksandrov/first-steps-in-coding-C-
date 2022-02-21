using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> command = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> toPrint = new List<string>();
            while (command[0] != "Done")
            {
                List<string> commands = new List<string>(command);
                switch (commands[0])
                {
                    case "Add Book":
                        if (books.Contains(commands[1]))
                        {
                            break;
                        }
                        books.Insert(0, commands[1]);
                        break;
                    case "Take Book":
                        if (!books.Contains(commands[1]))
                        {
                            break;
                        }
                        books.Remove(commands[1]);
                        break;
                    case "Swap Books":
                        if (books.Contains(commands[1]) && books.Contains(commands[2]))
                        {
                            int firstBook = int.Parse(commands[1]);
                            int secondBook = int.Parse(commands[2]);
                            var a = books[firstBook];
                            books[firstBook] = books[secondBook];

                        }
                        break;
                    case "Insert Book":
                        if (books.Contains(commands[1]))
                        {
                            break;
                        }
                        books.Add(commands[1]);
                        break;
                    case "Check Book":
                        var index = int.Parse(commands[1]);
                        if (index < 0 || index > books.Count -1)
                        {
                            break;
                        }
                        toPrint.Add(commands[1]);
                        break;
                    default:
                        break;
     
                }
                command = Console.ReadLine().Split('|').ToList();
            }
            Console.WriteLine(string.Join("\\n", toPrint));
            Console.WriteLine(string.Join(", ", books));
        }
    }
}
