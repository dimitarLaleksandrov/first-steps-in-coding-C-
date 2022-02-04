using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double apartment = 0.0;
            double studio = 0.0;
            double wholeStayS = 0.0;
            double wholeStayA = 0.0;
            switch (month)
            {
                 case "May":
                 case "October":
                apartment = 65.0;
                studio = 50.0;
                if(days > 7 && days <= 14)
                {
                    studio -= studio * 0.05;
                }
                else if(days > 14)
                {
                    apartment -= apartment * 0.10;
                    studio -= studio * 0.30;
                }
                wholeStayS = studio * days;
                wholeStayA = apartment * days;
                Console.WriteLine($"Apartment: {wholeStayA:f2} lv.");
                Console.WriteLine($"Studio: {wholeStayS:f2} lv.");
                    break;
                case "June":
                case "September":
                apartment = 68.70;
                studio = 75.20;
                if (days > 14)
                {
                    apartment -= apartment * 0.10;
                    studio -= studio * 0.20;
                }
                wholeStayS = studio * days;
                wholeStayA = apartment * days;
                Console.WriteLine($"Apartment: {wholeStayA:f2} lv.");
                Console.WriteLine($"Studio: {wholeStayS:f2} lv.");
                    break;
                case "July":
                case "August":
                apartment = 77.0;
                studio = 76.0;
                if (days > 14)
                {
                    apartment -= apartment * 0.10;
                }
                wholeStayS = studio * days;
                wholeStayA = apartment * days;
                Console.WriteLine($"Apartment: {wholeStayA:f2} lv.");
                Console.WriteLine($"Studio: {wholeStayS:f2} lv.");
                    break;
                default:
                    break;
            }
        }
    }
}
