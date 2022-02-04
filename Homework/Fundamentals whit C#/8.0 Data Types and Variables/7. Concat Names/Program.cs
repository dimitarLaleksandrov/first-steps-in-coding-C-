using System;

namespace _7._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string furstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{furstName}{delimiter}{secondName}");
        }
    }
}
