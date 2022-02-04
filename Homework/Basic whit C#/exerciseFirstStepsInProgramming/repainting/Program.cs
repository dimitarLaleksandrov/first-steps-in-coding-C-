using System;

namespace repainting
{
    class Program
    {
        static void Main(string[] args)
        {
           int plastic = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paintThinner = int.Parse(Console.ReadLine());
            int howersWork = int.Parse(Console.ReadLine());
            var plasticPrice = (plastic + 2) * 1.50;
            var paintProcent = paint * 0.10;
            var paintPrice = (paint + paintProcent) * 14.50;
            var paintThinnerPrice = paintThinner * 5.00;
            var bag = 0.40;
            var allMatirialPrice = plasticPrice + paintPrice + paintThinnerPrice + bag;
            var sumWorkers = (allMatirialPrice * 0.30) * howersWork;
            Console.WriteLine(sumWorkers + allMatirialPrice);
           
        }
    }
}
