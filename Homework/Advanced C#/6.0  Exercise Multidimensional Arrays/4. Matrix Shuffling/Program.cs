using System;

namespace _4._Matrix_Shuffling
{
    internal class MatrixShuffling
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            string[,] matrix = new string[rows, cols];
            FillMatrix(matrix);
            string cmd = "";
            while ((cmd = Console.ReadLine()) != "END")
            {
                if (!ValidateCmmand(cmd, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    string[] cmdParts = cmd.Split(' ');
                    int row1 = int.Parse(cmdParts[1]);
                    int col1 = int.Parse(cmdParts[2]);
                    int row2 = int.Parse(cmdParts[3]);
                    int col2 = int.Parse(cmdParts[4]);
                    string firstElement = matrix[row1, col1];
                    string secondElement = matrix[row2, col2];
                    matrix[row2, col2] = firstElement;
                    matrix[row1, col1] = secondElement;
                    PrintMatrix(matrix);
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool ValidateCmmand(string cmd, int rows, int cols)
        {
            string[] cmdParts = cmd.Split(' ');
            if (cmdParts[0] == "swap" && cmdParts.Length == 5)
            {
                int row1 = int.Parse(cmdParts[1]);
                int col1 = int.Parse(cmdParts[2]);
                int row2 = int.Parse(cmdParts[3]);
                int col2 = int.Parse(cmdParts[4]);
                if (row1 >= 0 && row1 < rows && col1 >= 0 && col1 < cols && row2 >= 0 && row2 < rows && col2 >= 0 && col2 < cols)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void FillMatrix(string[,] matrix)
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
