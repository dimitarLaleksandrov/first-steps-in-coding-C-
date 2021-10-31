using System;

namespace Exam_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double catFoodOneKilo = 12.45;
            int catNumber = int.Parse(Console.ReadLine());
            int smallCatCounter = 0;
            int largCatCounter = 0;
            int hugeCatCounter = 0;
            double allFood = 0;
            for (int i = 0; i < catNumber; i++)
            {
                double foodFrame = double.Parse(Console.ReadLine());
                if (foodFrame >= 100 && foodFrame < 200)
                {
                    allFood += foodFrame;
                    smallCatCounter++;
                }
                else if (foodFrame >= 200 && foodFrame < 300)
                {
                    allFood += foodFrame;
                    largCatCounter++;
                }
                else if (foodFrame >= 300 && foodFrame < 400)
                {
                    allFood += foodFrame;
                    hugeCatCounter++;
                }
            }
            double foodPrice = (allFood / 1000 ) * catFoodOneKilo;
            Console.WriteLine($"Group 1: {smallCatCounter} cats.");
            Console.WriteLine($"Group 2: {largCatCounter} cats.");
            Console.WriteLine($"Group 3: {hugeCatCounter} cats.");
            Console.WriteLine($"Price for food per day: {foodPrice:f2} lv.");
        }
    }
}
