using System;

namespace Exam_three
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int numberOfPlaySouvenirs = int.Parse(Console.ReadLine());
            decimal price = 0m;
            if (team != "Argentina" && team != "Brazil" && team != "Croatia" && team != "Denmark")
            {
                Console.WriteLine("Invalid country!");
            }
            if (souvenir != "flags" && souvenir != "caps" && souvenir != "posters" && souvenir != "stickers")
            {
                Console.WriteLine("Invalid stock!");
            }
            switch (team)
            {
                case "Argentina":
                switch (souvenir)
                    {
                        case "flags":
                            price = 3.25m;
                            break;
                        case "caps":
                            price = 7.20m;
                            break;
                        case "posters":
                            price = 5.10m;
                            break;
                        case "stickers":
                            price = 1.25m;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Brazil":
                    switch (souvenir)
                    {
                        case "flags":
                            price = 4.20m;
                            break;
                        case "caps":
                            price = 8.50m;
                            break;
                        case "posters":
                            price = 5.35m;
                            break;
                        case "stickers":
                            price = 1.20m;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Croatia":
                    switch (souvenir)
                    {
                        case "flags":
                            price = 2.75m;
                            break;
                        case "caps":
                            price = 6.90m;
                            break;
                        case "posters":
                            price = 4.95m;
                            break;
                        case "stickers":
                            price = 1.10m;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Denmark":
                    switch (souvenir)
                    {
                        case "flags":
                            price = 3.10m;
                            break;
                        case "caps":
                            price = 6.50m;
                            break;
                        case "posters":
                            price = 4.80m;
                            break;
                        case "stickers":
                            price = 0.90m;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            decimal sum = numberOfPlaySouvenirs * price;
            if (team == "Argentina" || team == "Brazil" || team == "Croatia" || team == "Denmark")
            {
                if (souvenir == "flags" || souvenir == "caps" || souvenir == "posters" || souvenir == "stickers")
                {
                    Console.WriteLine($"Pepi bought {numberOfPlaySouvenirs} {souvenir} of {team} for {sum:f2} lv.");
                }   
            }
        }
    }
}
