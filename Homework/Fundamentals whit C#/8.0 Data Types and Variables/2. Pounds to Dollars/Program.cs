
using System;

namespace _2._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollarConvert = pounds * 1.31m;
            Console.WriteLine($"{dollarConvert:f3}");
        }
    }
}
