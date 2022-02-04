using System;

namespace yardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double area = squareMeters * 7.61; 
            var discountRates = 0.18 * area;
            double finalPrice = area - discountRates;
           Console.WriteLine($"The final price is: {finalPrice}  lv.");
            Console.WriteLine($"The discount is: {discountRates} lv.");
        }
    }
}
