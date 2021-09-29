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
                if (theDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (theDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (theDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            if (degrees > 18 && degrees <= 24)
            {
                if (theDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (theDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (theDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            if (degrees >= 25)
            {
                if (theDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (theDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (theDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
