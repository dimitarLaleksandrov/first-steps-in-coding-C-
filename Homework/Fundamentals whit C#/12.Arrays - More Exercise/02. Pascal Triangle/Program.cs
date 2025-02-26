﻿using System;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] triangle = new int[n, n];

            triangle[0, 0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        triangle[i, j] = triangle[i, j] = 1;
                    }
                    else
                    {
                        triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{triangle[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
