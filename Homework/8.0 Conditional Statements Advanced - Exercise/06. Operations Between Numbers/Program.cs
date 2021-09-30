using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double nOne = double.Parse(Console.ReadLine());
            double nTwo = double.Parse(Console.ReadLine());
            string simbol = Console.ReadLine();
            double resolt = 0.00;
            if (simbol == "+")
            {
                resolt = nOne + nTwo;
                if (resolt % 2 == 0)
                {
                    Console.WriteLine($"{nOne} + {nTwo} = {resolt} - even");
                }
                else if (resolt % 2 == 1)
                {
                    Console.WriteLine($"{nOne} + {nTwo} = {resolt} - odd");
                }
            }
            else if (simbol == "-")
            {
                resolt = nOne - nTwo;
                if (resolt % 2 == 0)
                {
                    Console.WriteLine($"{nOne} - {nTwo} = {resolt} - even");
                }
                else if (resolt % 2 == 1)
                {
                    Console.WriteLine($"{nOne} - {nTwo} = {resolt} - odd");
                }
            }
            else if (simbol == "*")
            {
                resolt = nOne * nTwo;
                if (resolt % 2 == 0)
                {
                    Console.WriteLine($"{nOne} * {nTwo} = {resolt} - even");
                }
                else if (resolt % 2 == 1)
                {
                    Console.WriteLine($"{nOne} * {nTwo} = {resolt} - odd");
                }
            }
            else if (simbol == "/")
            {
                resolt = nOne / nTwo;
                if (nOne == 0)
                {
                    Console.WriteLine($"Cannot divide {nTwo} by zero");
                }
                else if (nTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {nOne} by zero");
                }
                else
                {
                    Console.WriteLine($"{nOne} / {nTwo} = {resolt:f2}");
                }
            }
            else if (simbol == "%")
            {
                resolt = nOne % nTwo;
                if (nOne == 0)
                {
                    Console.WriteLine($"Cannot divide {nTwo} by zero");
                }
                else if (nTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {nOne} by zero");
                }
                else
                {
                    Console.WriteLine($"{nOne} % {nTwo} = {resolt}");
                }
            }
        }
    }
}

