using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineOfProducts = int.Parse(Console.ReadLine());
            List<string> productName = new List<string>();
            for (int i = 1; i <= lineOfProducts; i++)
            {
                string product = Console.ReadLine();
                productName.Add(product);
            }
            productName.Sort();
            for (int i = 0; i < productName.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productName[i]}");
            }
        }
    }
}
