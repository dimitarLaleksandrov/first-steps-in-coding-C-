﻿using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string person = "";
            if (age >= 0 && age <= 2)
            {
                person = "baby";
            }
            if (age >= 3 && age <= 13)
            {
                person = "child";
            }
            if (age >= 14 && age <= 19)
            {
                person = "teenager";
            }
            if (age >= 20 && age <= 65)
            {
                person = "adult";
            }
            if (age >= 66)
            {
                person = "elder";
            }
            Console.WriteLine(person);
        }
    }
}
