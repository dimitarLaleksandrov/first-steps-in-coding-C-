using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string passInput = Console.ReadLine();
            while (passInput != pass)
            {
                passInput = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
