using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class SnakeMoves
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            char[,] matrix = new char[rows, cols];
            string snake = Console.ReadLine();
            int index = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                } 
            }
            for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row1, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
