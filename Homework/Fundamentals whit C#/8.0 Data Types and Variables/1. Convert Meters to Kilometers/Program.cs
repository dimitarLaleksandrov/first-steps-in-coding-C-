﻿using System;

namespace _1._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometerConverter = meters / 1000;
            Console.WriteLine($"{kilometerConverter:f2}");
        }
    }
}
