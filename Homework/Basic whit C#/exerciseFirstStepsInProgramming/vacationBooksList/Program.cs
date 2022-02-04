using System;

namespace vacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesForHower = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int howersPerDay = pages / pagesForHower;
            int howers = howersPerDay / days;
            Console.WriteLine(howers);
        }
    }
}
