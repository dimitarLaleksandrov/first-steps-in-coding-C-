using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal onePerson = 18;
            decimal apartment = 25;
            decimal presidentA = 35;
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            decimal prise = 0;
            if (days < 10)
            {
                switch (room)
                {
                    case "room for one person":
                        onePerson = 18;
                        prise = (days - 1) * onePerson;
                        break;
                    case "apartment":
                        apartment -= (apartment * 0.30m);
                        prise = (days - 1) * apartment;
                        break;
                    case "president apartment":
                        presidentA -= presidentA * 0.10m;
                        prise = (days - 1) * presidentA;
                        break;
                    default:
                        break;
                        switch (rating)
                        {
                            case "positive":
                                prise += prise * 0.25m;
                                break;
                            case "negative":
                                prise -= prise * 0.10m;
                                break;
                            default:
                                break;
                        }
                }
            }
            else if (days >= 10 && days <= 15)
            {
                switch (room)
                {
                    case "room for one person":
                        onePerson = 18.00m;
                        prise = (days - 1) * onePerson;
                        break;
                    case "apartment":
                        apartment -= apartment * 0.35m;
                        prise = (days - 1) * apartment;
                        break;
                    case "president apartment":
                        presidentA -= presidentA * 0.15m;
                        prise = (days - 1) * presidentA;
                        break;
                    default:
                        break;
                        switch (rating)
                        {
                            case "positive":
                                prise += prise * 0.25m;
                                break;
                            case "negative":
                                prise -= prise * 0.10m;
                                break;
                            default:
                                break;
                        }
                }
            }
            else if (days > 15)
            {
                switch (room)
                { 
                    case "room for one person":
                    onePerson = 18;
                    prise = (days - 1) * onePerson;
                    break;
                    case "apartment":
                        apartment -= (apartment * 0.50m);
                    prise = (days - 1) * apartment;
                    break;
                    case "president apartment":
                        presidentA -= presidentA * 0.20m;
                        prise = (days - 1) * presidentA;
                      break;
                        default:
                        break;
                      switch (rating)
                      {
                        case "positive":
                            prise += prise * 0.25m;
                            break;
                        case "negative":
                            prise -= prise * 0.10m;
                            break;
                        default:
                            break; 
                       }
                }
            }
            Console.WriteLine($"{prise:f2}");
        }
    }
}
