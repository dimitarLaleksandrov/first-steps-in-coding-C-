using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            RectangleCalculete(x, y);            
        }
        static double RectangleCalculete(double x, double y)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine(area);
            return area;
        }
    }
}
