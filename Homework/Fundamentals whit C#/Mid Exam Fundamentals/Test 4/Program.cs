using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_4
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine(string.Join(", ", books));


        }
    }
}
