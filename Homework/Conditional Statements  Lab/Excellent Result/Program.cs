using System;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
