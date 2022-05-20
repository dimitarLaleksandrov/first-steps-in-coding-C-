using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBoxes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(clothesInTheBoxes);
            int sumOfTheClothes = 0;
            int countrack = 1;
            for (int i = 0; i < clothesInTheBoxes.Length; i++)
            {
                int clotheValu = clothesInTheBoxes[i];
                if (sumOfTheClothes + clotheValu <= rackCapacity)
                {
                    sumOfTheClothes += clotheValu;
                }
                else
                {
                    sumOfTheClothes = clotheValu;
                    countrack++;

                }
            }
            Console.WriteLine(countrack);
        }
    }
}
