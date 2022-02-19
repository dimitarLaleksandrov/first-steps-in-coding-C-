using System;

namespace Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            decimal totalPriceWhitNoTaxes = 0m;
            while (comand != "regular" && comand != "special")
            {
                decimal price = decimal.Parse(comand);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    comand = Console.ReadLine();
                    continue;
                }
                totalPriceWhitNoTaxes += price;
                comand = Console.ReadLine();
            }
            if (totalPriceWhitNoTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            decimal taxes = totalPriceWhitNoTaxes * 0.2m;
            if (comand == "special")
            {
                decimal totalPriceWhitTaxes = totalPriceWhitNoTaxes + taxes;
                decimal totalpriceWhitDiscount = totalPriceWhitTaxes * 0.9m;  // 0.9m ==   - totalPriceWhitTaxes * 10 / 100;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWhitNoTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalpriceWhitDiscount:f2}$");
                
            }
            else if (comand == "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWhitNoTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPriceWhitNoTaxes + taxes:f2}$");
            }

        }
    }
}
