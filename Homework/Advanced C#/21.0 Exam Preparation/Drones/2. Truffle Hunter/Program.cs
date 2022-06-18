using System;

namespace _2._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            int blackTruffelsCount = 0;
            int summerTruffelslsCount = 0;
            int whiteTruffelsCount = 0;
            int truffelsBoardEaten = 0;
            string cmd = string.Empty;
            MatrixFiled(matrix, matrixSize);
            while ((cmd = Console.ReadLine()) != "Stop the hunt")
            {
                string cmdReport = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                int row = int.Parse(cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                int col = int.Parse(cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
                switch (cmdReport)
                {
                    case "Collect":
                        if (RowAndColValidaitInMatrix(row, col, matrixSize))
                        {
                            char truffel = matrix[row, col];
                            matrix[row, col] = '-';
                            switch (truffel)
                            {
                                case 'B':
                                    blackTruffelsCount++;
                                    break;
                                case 'W':
                                    whiteTruffelsCount++;
                                    break;
                                case 'S':
                                    summerTruffelslsCount++;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Row or Col are not in a Matrix valid point!");
                        }
                        break;
                    case "Wild_Boar":
                        if (RowAndColValidaitInMatrix(row, col, matrixSize))
                        {
                            string direction = cmd.Split()[3];
                            switch (direction)
                            {
                                case "up":
                                    while(IsTheGivenRowValid(row, matrixSize))
                                    {
                                        if(BoarIsEating(row, col, matrix))
                                        {
                                            truffelsBoardEaten++;
                                        }
                                        row -= 2;
                                    }
                                    break;
                                case "down":
                                    while (IsTheGivenRowValid(row, matrixSize))
                                    {
                                        if (BoarIsEating(row, col, matrix))
                                        {
                                            truffelsBoardEaten++;
                                        }
                                        row += 2;
                                    }
                                    break;
                                case "left":
                                    while (IsTheGivenColValid(col, matrixSize))
                                    {
                                        if (BoarIsEating(row, col, matrix))
                                        {
                                            truffelsBoardEaten++;
                                        }
                                        col -= 2;
                                    }
                                    break;
                                case "right":
                                    while (IsTheGivenColValid(col, matrixSize))
                                    {
                                        if (BoarIsEating(row, col, matrix))
                                        {
                                            truffelsBoardEaten++;
                                        }
                                        col += 2;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Row or Col are not in a Matrix valid point!");
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Peter manages to harvest {blackTruffelsCount} black, {summerTruffelslsCount} summer, and {whiteTruffelsCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {truffelsBoardEaten} truffles.");
            PrintMatrix(matrix);
        }
        private static bool BoarIsEating(int row, int col, char[,] matrix)
        {
            char curentBoarPlace = matrix[row, col];
            if(curentBoarPlace == 'S' || curentBoarPlace == 'W' || curentBoarPlace == 'B')
            {
                matrix[row, col] = '-';
                return true;
            }
            return false;
        }
        public static bool IsTheGivenRowValid (int row, int matrixSize)
        {
            return row >= 0 && row < matrixSize;
        }
        public static bool IsTheGivenColValid(int col, int matrixSize)
        {
            return col >= 0 && col < matrixSize;
        }
        public static bool RowAndColValidaitInMatrix(int row, int col, int matrixSize)
        {
            bool isOut = true;
            if(row < 0 && row >= matrixSize && col < 0 && col >= matrixSize)
            {
                 isOut = false;
            }
            return isOut;
        }
        public static void MatrixFiled(char[,] matrix, int matrixSize)
        {
            for (int rowI = 0; rowI < matrixSize; rowI++)
            {
                char[] cirentRolllElements =  Console.ReadLine().Replace(" ", String.Empty).ToCharArray();

                for (int cowI = 0; cowI < cirentRolllElements.Length; cowI++)
                {
                    matrix[rowI, cowI] = cirentRolllElements[cowI];
                }
            }
        }
        public static void PrintMatrix(char[,] matrix)
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
