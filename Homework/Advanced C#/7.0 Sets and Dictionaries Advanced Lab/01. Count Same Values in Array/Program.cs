using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            Dictionary<double, int> dictionary = new Dictionary<double, int>();
            int counter = 1;
            foreach (var number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, counter);
                }
                else
                {
                    dictionary[number] += counter;
                } 
            }
            foreach (var number in dictionary)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
