using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double onePerson = 18.00;
            double apartment = 25.00;
            double presidentA = 35.00;
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            double prise = 0.0;
            if(days < 10)
            {
                if(room == "room for one person")
                {
                    onePerson = 18.00;
                    prise = (days -1) * onePerson;
                }
                else if(room == "apartment")
                {
                    apartment -= apartment * 0.30;
                    prise = (days - 1) * apartment;
                }
                else if(room == "president apartment")
                {
                    presidentA -= presidentA * 0.10;
                    prise = (days -1) * presidentA;
                }
                if (rating == "positive")
                {
                    prise += prise * 0.25;
                }
                else if (rating == "negative")
                {
                    prise -= prise * 0.10;
                }
            }
            else if(days >= 10 && days <= 15)
            {
                if (room == "room for one person")
                {
                    onePerson = 18.00;
                    prise = (days - 1) * onePerson;
                }
                else if (room == "apartment")
                {
                    apartment -= apartment * 0.35;
                    prise = (days - 1) * apartment;
                }
                else if (room == "president apartment")
                {
                    presidentA -= presidentA * 0.15;
                    prise = (days - 1) * presidentA;
                }
                if (rating == "positive")
                {
                    prise += prise * 0.25;
                }
                else if (rating == "negative")
                {
                    prise -= prise * 0.10;
                }
            }
            else if(days > 15)
            {
                if (room == "room for one person")
                {
                    onePerson = 18.00;
                    prise = (days - 1) * onePerson;
                }
                else if (room == "apartment")
                {
                    apartment -= apartment * 0.50;
                    prise = (days - 1) * apartment;
                }
                else if (room == "president apartment")
                {
                    presidentA -= presidentA * 0.20;
                    prise = (days - 1) * presidentA;
                }
                if (rating == "positive")
                {
                    prise += prise * 0.25;
                }
                else if(rating == "negative")
                {
                    prise -= prise * 0.10;
                }
            }
            Console.WriteLine($"{prise:f2}");
        }
    }
}
