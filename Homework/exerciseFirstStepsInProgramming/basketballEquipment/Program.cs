using System;

namespace basketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double year = double.Parse(Console.ReadLine());
            var sneakers = year - (year * 0.40);
            var outfit = sneakers - (sneakers * 0.20);
            var ball = outfit * 0.25;
            var accessories = ball * 0.20;
            var allSum = sneakers + outfit + ball + accessories + year;
            Console.WriteLine(allSum);
        }
    }
}
