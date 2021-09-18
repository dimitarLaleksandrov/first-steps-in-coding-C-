using System;

namespace fishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int wigth = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double precentage = double.Parse(Console.ReadLine());
            var volume = length * wigth * height;
            var volumeLiters = volume * 0.001;
            var space = precentage / 100.0;
            var litersWater = volumeLiters * (1 - space);
            Console.WriteLine(litersWater);

        }
    }
}
