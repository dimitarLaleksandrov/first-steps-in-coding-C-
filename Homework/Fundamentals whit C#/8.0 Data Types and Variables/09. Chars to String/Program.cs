using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char furstLine = char.Parse(Console.ReadLine());
            char secondLine = char.Parse(Console.ReadLine());
            char therdLine = char.Parse(Console.ReadLine());
            Console.WriteLine($"{furstLine}{secondLine}{therdLine}");
        }
    }
}
