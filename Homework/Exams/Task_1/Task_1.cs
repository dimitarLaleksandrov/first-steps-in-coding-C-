using System;

namespace Task_1
{
    class Task_1
    {
        static void Main(string[] args)
        {
            const decimal dolar = 1.57m;
            decimal processorDolarPrise = decimal.Parse(Console.ReadLine());
            decimal videoCardDolarPrise = decimal.Parse(Console.ReadLine());
            decimal ramDolarPrise = decimal.Parse(Console.ReadLine());
            int countRam = int.Parse(Console.ReadLine());
            decimal discountRate = decimal.Parse(Console.ReadLine());
            decimal processorPriseLv = processorDolarPrise * dolar;
            decimal videoCardPriseLv = videoCardDolarPrise * dolar;
            decimal ramPriseLv = ramDolarPrise * dolar;
            decimal allRamPriseLv = ramPriseLv * countRam;
            decimal afretPriceOfDiscount = processorPriseLv - (processorPriseLv * discountRate);
            decimal videoCardPriceAfterDiscount = videoCardPriseLv - (videoCardPriseLv * discountRate);
            decimal totalPrise = afretPriceOfDiscount + videoCardPriceAfterDiscount + allRamPriseLv;
            Console.WriteLine($"Money needed - {totalPrise:f2} leva.");
        }
    }
}
