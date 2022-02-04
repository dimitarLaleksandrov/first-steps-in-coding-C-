using System;

namespace inchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimeters = double.Parse(Console.ReadLine());
            double inches = centimeters * 2.54d;
            Console.WriteLine(inches);
        }
    }
}
