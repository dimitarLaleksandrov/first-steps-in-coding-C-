using System;

namespace radiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle = double.Parse(Console.ReadLine());
            double degrees = angle * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}
