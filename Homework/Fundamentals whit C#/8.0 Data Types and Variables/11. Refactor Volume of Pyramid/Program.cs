using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double fundamental, slantHeight, altitude = 0;
            fundamental = double.Parse(Console.ReadLine());
            slantHeight = double.Parse(Console.ReadLine());
            altitude = double.Parse(Console.ReadLine());
            double v = (fundamental * slantHeight * altitude) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {v:f2}");
        }
    }
}
