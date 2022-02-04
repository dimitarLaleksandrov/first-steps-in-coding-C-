using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int order = int.Parse(Console.ReadLine());
            decimal orderPrice = 0m;
            decimal allPrice = 0;
            for (int i = 1; i <= order; i++)
            {             
                decimal priceOfCapsul = decimal.Parse(Console.ReadLine());
                 int days = int.Parse(Console.ReadLine());
                 int capsulCounter = int.Parse(Console.ReadLine());
                orderPrice = priceOfCapsul * days * capsulCounter;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                allPrice += orderPrice;
            }
            Console.WriteLine($"Total: ${allPrice:f2}");
        }
    }
}
