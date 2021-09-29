using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double price = 0.0;
            if(projection == "Premiere")
            {
                price = (colums * rows) * 12.00;
            }
            else if(projection == "Normal")
            {
                price = (colums * rows) * 7.50;
            }
            else if(projection == "Discount")
            {
                price = (colums * rows) * 5.00;
            }
            Console.WriteLine($"{price:f2} leva");
        }
    }
}
