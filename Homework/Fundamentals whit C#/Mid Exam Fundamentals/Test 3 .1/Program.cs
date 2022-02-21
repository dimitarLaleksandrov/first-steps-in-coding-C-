using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_3_._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = Console.ReadLine().Split('&', StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = commands[0].Trim();
            Console.WriteLine(commands);
            while (commands[0] != "Done")
            {
                Console.WriteLine(commands[0]);
                //switch (commands[0])
                //{
                //    case "Add Book":
                //        books.Insert(0, commands[1]);
                //    break;
                //    case "Take Book":
                //        books.Remove(commands[1]);
                //        break;
                //    case "Swap Books":
                //        if (books.Contains(commands[1]) && books.Contains(commands[2]))
                //        {
                //            string firstBook = commands[1];
                //            string secondBook = commands[2];
                //            int index1 = books.IndexOf(firstBook);
                //            int index2 = books.IndexOf(secondBook);
                //            books[index1] = secondBook;
                //            books[index2] = firstBook;

                //        }
                //        break;
                //    default:
                //        break;
                //}
                if (commands[0] == "Add Book")
                {
                    books.Insert(0, commands[1]);
                }
                else if (commands[0] == "Take Book")
                {
                    books.Remove(commands[1]);
                }
                else if (commands[0] == "Swap Books")
                {
                    if (books.Contains(commands[1]) && books.Contains(commands[2]))
                    {
                        string firstBook = commands[1];
                        string secondBook = commands[2];
                        int index1 = books.IndexOf(firstBook);
                        int index2 = books.IndexOf(secondBook);
                        books[index1] = secondBook;
                        books[index2] = firstBook;

                    }
                }
                commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.WriteLine(string.Join(" ", books));
        }
    }
}
