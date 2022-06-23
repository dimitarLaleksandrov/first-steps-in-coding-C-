using System;

namespace _2._Bee
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            const int pollinatedFlowersNeedet = 5;
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            FillMatrix(matrix, matrixSize);
            int beeRow = 0;
            int beeCol = 0;
            int pollinatesFlower = 0;
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if(matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
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
                        beeRow -= 1;
                        matrix[beeRow + 1, beeCol] = '.';
                        if (ValidatePosishan(beeRow, beeCol, matrixSize))
                        {
                            if (matrix[beeRow, beeCol] == 'f')
                            {
                                matrix[beeRow, beeCol] = 'B';
                                pollinatesFlower++;
                            }
                            else if (matrix[beeRow, beeCol] == 'O')
                            {
                                beeRow -= 1;
                                matrix[beeRow + 1, beeCol] = '.';
                                if (ValidatePosishan(beeRow, beeCol, matrixSize))
                                {
                                    if (matrix[beeRow, beeCol] == 'f')
                                    {
                                        matrix[beeRow, beeCol] = 'B';
                                        pollinatesFlower++;
                                    }
                                    else
                                    {
                                        matrix[beeRow, beeCol] = 'B';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The bee got lost!");
                                    isItOut = false;
                                }
                            }
                            else
                            {
                                matrix[beeRow, beeCol] = 'B';
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            isItOut = false;
                        }
                        break;
                    case "down":
                        beeRow += 1;
                        matrix[beeRow - 1, beeCol] = '.';
                        if (ValidatePosishan(beeRow, beeCol, matrixSize))
                        {
                            if (matrix[beeRow, beeCol] == 'f')
                            {
                                matrix[beeRow, beeCol] = 'B';
                                pollinatesFlower++;
                            }
                            else if (matrix[beeRow, beeCol] == 'O')
                            {
                                beeRow += 1;
                                matrix[beeRow - 1, beeCol] = '.';
                                if (ValidatePosishan(beeRow, beeCol, matrixSize))
                                {
                                    if (matrix[beeRow, beeCol] == 'f')
                                    {
                                        matrix[beeRow, beeCol] = 'B';
                                        pollinatesFlower++;
                                    }
                                    else
                                    {
                                        matrix[beeRow, beeCol] = 'B';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The bee got lost!");
                                    isItOut = false;
                                }
                            }
                            else
                            {
                                matrix[beeRow, beeCol] = 'B';
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            isItOut = false;
                        }
                        break;
                    case "left":
                        beeCol -= 1;
                        matrix[beeRow, beeCol + 1] = '.';
                        if (ValidatePosishan(beeRow, beeCol, matrixSize))
                        {
                            if (matrix[beeRow, beeCol] == 'f')
                            {
                                matrix[beeRow, beeCol] = 'B';
                                pollinatesFlower++;
                            }
                            else if (matrix[beeRow, beeCol] == 'O')
                            {
                                beeCol -= 1;
                                matrix[beeRow, beeCol + 1] = '.';
                                if (ValidatePosishan(beeRow, beeCol, matrixSize))
                                {
                                    if (matrix[beeRow, beeCol] == 'f')
                                    {
                                        matrix[beeRow, beeCol] = 'B';
                                        pollinatesFlower++;
                                    }
                                    else
                                    {
                                        matrix[beeRow, beeCol] = 'B';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The bee got lost!");
                                    isItOut = false;
                                }
                            }
                            else
                            {
                                matrix[beeRow, beeCol] = 'B';
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            isItOut = false;
                        }
                        break;
                    case "right":
                        beeCol += 1;
                        matrix[beeRow, beeCol - 1] = '.';
                        if (ValidatePosishan(beeRow, beeCol, matrixSize))
                        {
                            if (matrix[beeRow, beeCol] == 'f')
                            {
                                matrix[beeRow, beeCol] = 'B';
                                pollinatesFlower++;
                            }
                            else if (matrix[beeRow, beeCol] == 'O')
                            {
                                beeCol += 1;
                                matrix[beeRow, beeCol - 1] = '.';
                                if (ValidatePosishan(beeRow, beeCol, matrixSize))
                                {
                                    if (matrix[beeRow, beeCol] == 'f')
                                    {
                                        matrix[beeRow, beeCol] = 'B';
                                        pollinatesFlower++;
                                    }
                                    else
                                    {
                                        matrix[beeRow, beeCol] = 'B';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The bee got lost!");
                                    isItOut = false;
                                }
                            }
                            else
                            {
                                matrix[beeRow, beeCol] = 'B';
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            isItOut = false;
                        }
                        break;
                    default:
                        break;
                }
                if(isItOut == false)
                {
                    break;
                }
            }
            if(pollinatesFlower >= pollinatedFlowersNeedet)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatesFlower} flowers!");
            }
            else
            {
                var pollinateNeeded = pollinatedFlowersNeedet - pollinatesFlower;
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {pollinateNeeded} flowers more");
            }
            PrintMatrix(matrix);
        }
        public static void FillMatrix(char[,] matrix, int matrixSize)
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
        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(col > 0)
                    {
                        Console.Write("");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
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
    }
}
