using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Queue<string> names = new Queue<string>();
            int counterNames = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    names.Enqueue(input);
                    counterNames++;
                }
                if (input == "Paid")
                {
                    for (int i = 1; i <= counterNames; i++)
                    {
                        var name = names.Dequeue();
                        Console.WriteLine(name);
                    }
                    counterNames = 0;
                }  
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
