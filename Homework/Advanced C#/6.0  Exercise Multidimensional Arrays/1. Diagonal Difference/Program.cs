using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int leftCrosSum = 0;
            int rithCrosSum = 0;
            FillMatrix(matrix);
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        leftCrosSum += matrix[row, col];    
                    }
                    if (row + col == n - 1)
                    {
                        rithCrosSum += matrix[row, col];
                    }
                }
            }
            int difference = Math.Abs(leftCrosSum - rithCrosSum);
            Console.WriteLine(difference);
        }
        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
        }
    }
}
