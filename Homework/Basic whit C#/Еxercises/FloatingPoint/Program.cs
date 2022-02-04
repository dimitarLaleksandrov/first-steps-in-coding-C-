using System;

namespace FloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double double1 = 0.000001d;
            double double2 = 0.000001d;
            double double3 = 0.000001d;
            Console.WriteLine("{0:F7}", double1 + double2 + double3 + double1 + double2 + double3);
            Console.WriteLine(double1 + double2 + double3 + double1 + double2 + double3 == 6 * double1);




        }
    }
}
