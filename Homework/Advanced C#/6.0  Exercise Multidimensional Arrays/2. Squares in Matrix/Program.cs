using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);
            string[,] matrix = new string[rows, cols];
            FillMatrix(matrix);
            int matrixCounter2X2 = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        matrixCounter2X2++;
                    }
                }
            }
            Console.WriteLine(matrixCounter2X2);
        }
        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }

    }
}
