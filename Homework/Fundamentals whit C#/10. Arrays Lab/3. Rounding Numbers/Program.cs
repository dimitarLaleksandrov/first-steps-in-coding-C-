using System;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            double[] items = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                items[i] = double.Parse(numbers[i]);  
            }
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
