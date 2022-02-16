using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bombNum = bombInfo[0];
            int bombPower = bombInfo[1];
            int indexOfBomb; //input.IndexOf(bombNum)
            while ((indexOfBomb = input.IndexOf(bombNum)) >= 0)
            {
                if (indexOfBomb == -1)
                {
                    break;
                }
                DetonaitBomb(input, indexOfBomb, bombPower);
            }
            Console.WriteLine(input.Sum());
        }
        static void DetonaitBomb(List<int> input, int indexOfBomb, int bombPower)
        {
            int rightIndex = indexOfBomb + bombPower;
            for (int i = indexOfBomb; i <= rightIndex; i++)
            {
                if (indexOfBomb >= input.Count)
                {
                    break;
                }
                input.RemoveAt(indexOfBomb);
            }
            int leftIndex = indexOfBomb - bombPower;
            if (leftIndex < 0)
            {
                leftIndex = 0;
            }
            for (int i = leftIndex; i < indexOfBomb; i++)
            {
                if (leftIndex >= input.Count)
                {
                    break;
                }
                input.RemoveAt(leftIndex);
            }
        } 
    }
}
