using System;

namespace suppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int chemicals = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int reduction = int.Parse(Console.ReadLine());
            double priceOfChemicals = chemicals * 5.80;
            double priceOfMarkers = markers * 7.20;
            double priceOfDetergent = detergent * 1.20;
            double reductionInEnds = reduction / 100.0;
            var allPriceMatetials = priceOfDetergent + priceOfMarkers + priceOfChemicals;
            var allPrice = allPriceMatetials - (allPriceMatetials * reductionInEnds);
            Console.WriteLine(allPrice);
        }
    }
}
