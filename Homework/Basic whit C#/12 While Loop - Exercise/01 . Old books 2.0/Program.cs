using System;

namespace _01_._Old_books_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string newBook = Console.ReadLine();
            string book = Console.ReadLine();
            int counterBook = 0;
            while (book != "No More Books")
            {
                if (book == newBook)
                {
                    Console.WriteLine($"You checked {counterBook} books and found it.");
                    break;
                }
                counterBook++;
                book = Console.ReadLine();
            }
            if (book  == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterBook} books.");
            }
        }
    }
}
