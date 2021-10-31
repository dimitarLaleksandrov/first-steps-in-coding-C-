using System;

namespace Exam_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pages = 899;
            const int covers = 2;
            decimal pagePrice = decimal.Parse(Console.ReadLine());
            decimal coverPrice = decimal.Parse(Console.ReadLine());
            int priceReductionPercent = int.Parse(Console.ReadLine());
            decimal designerPrice = decimal.Parse(Console.ReadLine());
            int allSumPercent = int.Parse(Console.ReadLine());
            decimal startSum = (pagePrice * pages) + (coverPrice * covers);
            decimal priceReduction = startSum - ((priceReductionPercent * startSum) / 100);
            decimal plusDesigner = priceReduction + designerPrice;
            decimal endSum = plusDesigner - ((allSumPercent * plusDesigner) / 100);
            Console.WriteLine($"Avtonom should pay {endSum:f2} BGN.");
        }
    }
}
