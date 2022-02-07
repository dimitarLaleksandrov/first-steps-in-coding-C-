using System;

namespace _2._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graid(double.Parse(Console.ReadLine()));
            static double Graid(double input)
            {
                if (input >= 2.00 && input < 3)
                {
                    Console.WriteLine("Fail");
                }
                else if (input >= 3 && input < 3.50)
                {
                    Console.WriteLine("Poor");
                }
                else if (input >= 3.50 && input < 4.50)
                {
                    Console.WriteLine("Good");
                }
                else if (input >= 4.50 && input < 5.50)
                {
                    Console.WriteLine("Very good");
                }
                else if (input >= 5.50 && input <= 6)
                {
                    Console.WriteLine("Excellent");
                }
                return input;
            }
        }
    }
}
