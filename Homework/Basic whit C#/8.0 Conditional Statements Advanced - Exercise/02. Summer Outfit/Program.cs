using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string theDay = Console.ReadLine();
            string outfit = "clothes";
            string shoes = "shoes";
            if (degrees >= 10 && degrees <= 18)
            {
                switch (theDay)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    default:
                        break;
                }
            }
            if (degrees > 18 && degrees <= 24)
            {
                switch (theDay)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    default:
                        break;

                }
                if (degrees >= 25)
                {
                    switch (theDay)
                    {
                        case "Morning":
                            outfit = "T-Shirt";
                            shoes = "Sandals"; ;
                            break;
                        case "Afternoon":
                            outfit = "Swim Suit";
                            shoes = "Barefoot";
                            break;
                        case "Evening":
                            outfit = "Shirt";
                            shoes = "Moccasins";
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
