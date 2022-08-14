using System;
using System.Linq;

namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (double n in array)
            {
                int rounded = (int)Math.Round(n, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", n, rounded);
            }
        }
    }
}
