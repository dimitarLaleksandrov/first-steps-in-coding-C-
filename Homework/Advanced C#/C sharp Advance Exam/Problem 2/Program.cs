using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            FillTheMatrix(matrix);
            int vankoRow = 0;
            int vankoCol = 0;
            int holes = 1;
            int steelRob = 0;
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == 'V')
                    {
                        vankoRow = row;
                        vankoCol = col;
                    }
                }
            }
            string cmd = string.Empty;
            bool isItOut = true;
            while ((cmd = Console.ReadLine()) != "End")
            {
                switch (cmd)
                {
                    case "up":
                        vankoRow -= 1; 
                        if (ValidatePosishan(vankoRow, vankoCol, matrixSize))
                        {
                            if (matrix[vankoRow, vankoCol] == 'R')
                            {
                                steelRob++;
                                vankoRow += 1;
                                Console.WriteLine($"Vanko hit a rod!");
                            }
                            else if (matrix[vankoRow, vankoCol] == 'C')
                            {
                                matrix[vankoRow, vankoCol] = 'E';
                                matrix[vankoRow + 1, vankoCol] = '*';
                                holes++;
                                isItOut = false;
                            }
                            else if(matrix[vankoRow, vankoCol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                                matrix[vankoRow + 1, vankoCol] = '*';
                                matrix[vankoRow, vankoCol] = 'V';
                            }
                            else if (matrix[vankoRow, vankoCol] == '-')
                            {
                                matrix[vankoRow + 1, vankoCol] = '*';
                                matrix[vankoRow, vankoCol] = 'V';
                                holes++;
                            }
                        }
                        else
                        {
                            vankoRow += 1;
                        }
                        break;
                    case "down":
                        vankoRow += 1;
                        if (ValidatePosishan(vankoRow, vankoCol, matrixSize))
                        {
                            if (matrix[vankoRow, vankoCol] == 'R')
                            {
                                steelRob++;
                                vankoRow -= 1;
                                Console.WriteLine($"Vanko hit a rod!");
                            }
                            else if (matrix[vankoRow, vankoCol] == 'C')
                            {
                                matrix[vankoRow, vankoCol] = 'E';
                                matrix[vankoRow - 1, vankoCol] = '*';
                                holes++;
                                isItOut = false;
                            }
                            else if (matrix[vankoRow, vankoCol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                                matrix[vankoRow - 1, vankoCol] = '*';
                                matrix[vankoRow, vankoCol] = 'V';
                            }
                            else if (matrix[vankoRow, vankoCol] == '-')
                            {
                                matrix[vankoRow - 1, vankoCol] = '*';
                                matrix[vankoRow, vankoCol] = 'V';
                                holes++;
                            } 
                        }
                        else
                        {
                            vankoRow -= 1;
                        }
                        break;
                    case "left":
                        vankoCol -= 1;
                        if (ValidatePosishan(vankoRow, vankoCol, matrixSize))
                        {
                            if (matrix[vankoRow, vankoCol] == 'R')
                            {
                                vankoCol += 1;
                                steelRob++;
                                Console.WriteLine($"Vanko hit a rod!");
                            }
                            else if (matrix[vankoRow, vankoCol] == 'C')
                            {
                                matrix[vankoRow, vankoCol] = 'E';
                                matrix[vankoRow, vankoCol + 1] = '*';
                                holes++;
                                isItOut = false;
                            }
                            else if (matrix[vankoRow, vankoCol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                                matrix[vankoRow, vankoCol + 1] = '*';
                                matrix[vankoRow, vankoCol] = 'V';
                            }
                            else if (matrix[vankoRow, vankoCol] == '-')
                            {
                                matrix[vankoRow, vankoCol + 1] = '*';
                                matrix[vankoRow, vankoCol] = 'V';
                                holes++;
                            }
                        }
                        else
                        {
                            vankoCol += 1;
                        }
                        break;
                    case "right":
                        vankoCol += 1;
                        if (ValidatePosishan(vankoRow, vankoCol, matrixSize))
                        {
                            if (matrix[vankoRow, vankoCol] == 'R')
                            {
                                vankoCol -= 1;
                                steelRob++;
                                Console.WriteLine($"Vanko hit a rod!");
                            }
                            else if (matrix[vankoRow, vankoCol] == 'C')
                            {
                                matrix[vankoRow, vankoCol] = 'E';
                                matrix[vankoRow, vankoCol - 1] = '*';
                                holes++;
                                isItOut = false;
                            }
                            else if (matrix[vankoRow, vankoCol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                                matrix[vankoRow, vankoCol - 1] = '*';
                                matrix[vankoRow, vankoCol] = 'V';
                            }
                            else if (matrix[vankoRow, vankoCol] == '-')
                            {
                                matrix[vankoRow, vankoCol - 1] = '*';
                                matrix[vankoRow, vankoCol] = 'V';
                                holes++;
                            }
                        }
                        else
                        {
                            vankoCol -= 1;
                        }
                        break;
                    default:
                        break;
                }
                if (isItOut == false)
                {
                    break;
                }
            }
            if(isItOut == false)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {steelRob} rod(s).");
            }
            Printmatrix(matrix);
        }
        public static bool ValidatePosishan(int row, int col, int matrixSize)
        {
            bool isOut = false;
            if (row >= 0 && row < matrixSize && col >= 0 && col < matrixSize)
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
        public static void FillTheMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
