using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] quantityOfOrders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> quantitys = new Queue<int>(quantityOfOrders);
            Console.WriteLine(quantitys.Max());
            int lastQuantityToCheck = 0;
            for (int i = 0; i < quantityOfOrders.Length; i++)
            {
                if (quantityOfOrders[i] < foodQuantity)
                {
                    quantitys.Dequeue();
                    foodQuantity -= quantityOfOrders[i];
                }
                else
                {
                    lastQuantityToCheck = quantityOfOrders[i];
                    break;
                }
            }
            if (foodQuantity >= 0 && foodQuantity >= lastQuantityToCheck)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", quantitys)}");
            }
        }
    }
}
