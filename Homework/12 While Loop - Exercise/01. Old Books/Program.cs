using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string book = "";
            int counter = 0;
            while (bookName != book)
            {
                string books = Console.ReadLine();
                if (books == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                }
                else if (books == bookName)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                }
                counter++;
            }
        }
    }
}
