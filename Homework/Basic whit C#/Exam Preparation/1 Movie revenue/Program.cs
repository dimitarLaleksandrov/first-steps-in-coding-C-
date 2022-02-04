using System;

namespace _1_Movie_revenue
{
    class Program
    {
        static void Main(string[] args)
        {
            string moveieName = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
            int ticketNum = int.Parse(Console.ReadLine());
            decimal priceOfTicket = decimal.Parse(Console.ReadLine());
            double cinemaProcent = double.Parse(Console.ReadLine());
            decimal incomeForCinemaProcent  = (((ticketNum * priceOfTicket) * day) * (decimal)cinemaProcent / 100);
            decimal incomeForCinema = ((ticketNum * priceOfTicket) * day - incomeForCinemaProcent);
            Console.WriteLine($"The profit from the movie {moveieName} is {incomeForCinema:f2} lv.");
        }
    }
}
