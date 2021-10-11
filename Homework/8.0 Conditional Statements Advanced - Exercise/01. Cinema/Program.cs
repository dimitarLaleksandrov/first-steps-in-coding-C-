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
            decimal price = 0;
            switch (projection)
            {
                case "Premiere":
                    price = (rows * colums) * 12m;
                    break;
                case "Normal":
                    price = (rows * colums) * 7.50m;
                    break;
                case "Discount":
                    price = (rows * colums) * 5m;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{price:f2} leva");
        }
    }
}
