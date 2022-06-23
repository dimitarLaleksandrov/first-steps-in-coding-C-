using System;

namespace _2._Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int foodQuantityneede = 10;
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            FillTheMatrix(matrix, matrixSize);
            int snaceRow = 0;
            int snaceCol = 0;
            int foodCounter = 0;
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if(matrix[row, col] == 'S')
                    {
                        snaceRow = row;
                        snaceCol = col;
                    }
                }
            }
            bool flag = true;
            while (foodCounter < foodQuantityneede)
            {
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "up":
                        snaceRow -= 1;
                        if (IsTheSnakeOut(snaceRow, snaceCol, matrixSize))
                        {
                            matrix[snaceRow + 1, snaceCol] = '.';
                            if (matrix[snaceRow, snaceCol] == '*')
                            {
                                matrix[snaceRow, snaceCol] = 'S';
                                foodCounter++;
                            }
                            else if (matrix[snaceRow, snaceCol] == 'B')
                            {
                                matrix[snaceRow, snaceCol] = '.';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'B')
                                        {
                                            matrix[row, col] = 'S';
                                            snaceRow = row;
                                            snaceCol = col;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                matrix[snaceRow, snaceCol] = 'S';
                            }
                        }
                        else
                        {
                            matrix[snaceRow + 1, snaceCol] = '.';
                            flag = false;
                        }
                        break;
                    case "down":
                        snaceRow += 1;
                        if (IsTheSnakeOut(snaceRow, snaceCol, matrixSize))
                        {
                            matrix[snaceRow - 1, snaceCol] = '.';
                            if (matrix[snaceRow, snaceCol] == '*')
                            {
                                matrix[snaceRow, snaceCol] = 'S';
                                foodCounter++;
                            }
                            else if (matrix[snaceRow, snaceCol] == 'B')
                            {
                                matrix[snaceRow, snaceCol] = '.';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'B')
                                        {
                                            matrix[row, col] = 'S';
                                            snaceRow = row;
                                            snaceCol = col;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                matrix[snaceRow, snaceCol] = 'S';
                            }
                        }
                        else
                        {
                            matrix[snaceRow - 1, snaceCol] = '.';
                            flag = false;
                        }
                        break;
                    case "left":
                        snaceCol -= 1;
                        if (IsTheSnakeOut(snaceRow, snaceCol, matrixSize))
                        {
                            matrix[snaceRow , snaceCol + 1] = '.';
                            if (matrix[snaceRow, snaceCol] == '*')
                            {
                                matrix[snaceRow, snaceCol] = 'S';
                                foodCounter++;
                            }
                            else if (matrix[snaceRow, snaceCol] == 'B')
                            {
                                matrix[snaceRow, snaceCol] = '.';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'B')
                                        {
                                            matrix[row, col] = 'S';
                                            snaceRow = row;
                                            snaceCol = col;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                matrix[snaceRow, snaceCol] = 'S';
                            }
                        }
                        else
                        {
                            matrix[snaceRow, snaceCol + 1] = '.';
                            flag = false;
                        }
                        break;
                    case "right":
                        snaceCol += 1;
                        if (IsTheSnakeOut(snaceRow, snaceCol, matrixSize))
                        {
                            matrix[snaceRow , snaceCol - 1] = '.';
                            if (matrix[snaceRow, snaceCol] == '*')
                            {
                                matrix[snaceRow, snaceCol] = 'S';
                                foodCounter++;
                            }
                            else if (matrix[snaceRow, snaceCol] == 'B')
                            {
                                matrix[snaceRow, snaceCol] = '.';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'B')
                                        {
                                            matrix[row, col] = 'S';
                                            snaceRow = row;
                                            snaceCol = col;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                matrix[snaceRow, snaceCol] = 'S';
                            }
                        }
                        else
                        {
                            matrix[snaceRow, snaceCol - 1] = '.';
                            flag = false;
                        }
                        break;
                    default:
                        break;
                }
                if(flag == false)
                {
                    break;
                }
            }
            if(flag == false)
            {
                Console.WriteLine($"Game over!");
            }
            else
            {
                Console.WriteLine($"You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {foodCounter}");
            Printmatrix(matrix);
        }
        public static bool IsTheSnakeOut(int row, int col, int matrixSize)
        {
            bool isOut = false;
            if(row >= 0 && row < matrixSize && col >= 0 && col < matrixSize)
            {
                isOut = true;
            }
            return isOut;
        }
        public static void Printmatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        Console.Write("");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        public static void FillTheMatrix(char[,] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
