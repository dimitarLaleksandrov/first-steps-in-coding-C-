using System;
using System.Linq;

namespace _2._0_Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int armorySize = int.Parse(Console.ReadLine());
            string[,] matrix = new string[armorySize, armorySize];
            FillMatrix(matrix, armorySize);
            PrintMatrix(matrix);
        }

        public static void FillMatrix(string[,] matrix, int matrixSize)
        {
            for (int rowI = 0; rowI < matrixSize; rowI++)
            {
                string[] inputField = Console.ReadLine().Split("", StringSplitOptions.RemoveEmptyEntries);
                for (int colI = 0; colI < inputField.Length; colI++)
                {
                    matrix[rowI, colI] = inputField[colI];
                }
            }
        }
        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
