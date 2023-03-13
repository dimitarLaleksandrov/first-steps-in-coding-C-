using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._0_Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int atLeastSpendetGold = 65;
            int armorySize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[armorySize, armorySize];
            int armyOfficerRow = 0;
            int armyOfficerCol = 0;
            int coinNumColect = 0;
            FillMatrix(matrix, armorySize);
            for (int rowI = 0; rowI < armorySize; rowI++)
            {
                for (int colI = 0; colI < armorySize; colI++)
                {
                    if (matrix[rowI, colI] == 'A')
                    {
                        armyOfficerRow = rowI;
                        armyOfficerCol = colI;
                    }
                }
            }
            bool brakeTheWhile = true;
            while (brakeTheWhile && coinNumColect <= atLeastSpendetGold)
            {
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "up":
                        armyOfficerRow -= 1;
                        matrix[armyOfficerRow + 1, armyOfficerCol] = '-';
                        if(RowAndColValidaitInMatrix(armyOfficerRow, armyOfficerCol, armorySize))
                        {
                            if (char.IsDigit(matrix[armyOfficerRow, armyOfficerCol]))
                            {
                                char n = matrix[armyOfficerRow, armyOfficerCol];
                                int nToInt = int.Parse(n.ToString());
                                coinNumColect += nToInt;
                            }
                            else if (matrix[armyOfficerRow, armyOfficerCol] == 'M')
                            {
                                armyOfficerRow -= 2;
                                matrix[armyOfficerRow + 2, armyOfficerCol] = '-';
                                if (RowAndColValidaitInMatrix(armyOfficerRow, armyOfficerCol, armorySize))
                                {
                                    matrix[armyOfficerRow + 1, armyOfficerCol] = '-';
                                    matrix[armyOfficerRow, armyOfficerCol] = 'A';
                                }
                                else
                                {
                                    brakeTheWhile = false;
                                }                               
                            }
                        }
                        else
                        {
                           brakeTheWhile = false;
                        }
                        break;
                    case "down":
                        armyOfficerRow += 1;
                        matrix[armyOfficerRow - 1, armyOfficerCol] = '-';
                        if (RowAndColValidaitInMatrix(armyOfficerRow, armyOfficerCol, armorySize))
                        {
                            if (char.IsDigit(matrix[armyOfficerRow, armyOfficerCol]))
                            {
                                char n = matrix[armyOfficerRow, armyOfficerCol];
                                int nToInt = int.Parse(n.ToString());
                                coinNumColect += nToInt;
                                matrix[armyOfficerRow, armyOfficerCol] = 'A';
                            }
                            else if (matrix[armyOfficerRow, armyOfficerCol] == 'M')
                            {
                                armyOfficerRow += 2;
                                matrix[armyOfficerRow - 2, armyOfficerCol] = '-';
                                if (RowAndColValidaitInMatrix(armyOfficerRow, armyOfficerCol, armorySize))
                                {
                                    matrix[armyOfficerRow - 1, armyOfficerCol] = '-';                                  
                                    matrix[armyOfficerRow, armyOfficerCol] = 'A';
                                }
                                else
                                {
                                    brakeTheWhile = false;
                                }                             
                            }
                        }
                        else
                        {
                            brakeTheWhile = false;
                        }
                        break;
                    case "left":
                        armyOfficerCol -= 1;
                        matrix[armyOfficerRow, armyOfficerCol + 1] = '-';
                        if (RowAndColValidaitInMatrix(armyOfficerRow, armyOfficerCol, armorySize))
                        {
                            if (char.IsDigit(matrix[armyOfficerRow, armyOfficerCol]))
                            {
                                char n = matrix[armyOfficerRow, armyOfficerCol];
                                int nToInt = int.Parse(n.ToString());
                                coinNumColect += nToInt;
                                matrix[armyOfficerRow, armyOfficerCol] = 'A';
                            }
                            else if (matrix[armyOfficerRow, armyOfficerCol] == 'M')
                            {
                                armyOfficerCol -= 2;
                                matrix[armyOfficerRow, armyOfficerCol + 2] = '-';
                                if (RowAndColValidaitInMatrix(armyOfficerRow, armyOfficerCol, armorySize))
                                {
                                    matrix[armyOfficerRow, armyOfficerCol + 1] = '-';
                                    matrix[armyOfficerRow, armyOfficerCol] = 'A';
                                }
                                else
                                {
                                    brakeTheWhile = false;
                                }                             
                            }
                        }
                        else
                        {
                            brakeTheWhile = false;
                        }
                        break;
                    case "right":
                        armyOfficerCol += 1;
                        matrix[armyOfficerRow, armyOfficerCol - 1] = '-';
                        if (RowAndColValidaitInMatrix(armyOfficerRow, armyOfficerCol, armorySize))
                        {
                            if (char.IsDigit(matrix[armyOfficerRow, armyOfficerCol]))
                            {
                                char n = matrix[armyOfficerRow, armyOfficerCol];
                                int nToInt = int.Parse(n.ToString());
                                coinNumColect += nToInt;
                                matrix[armyOfficerRow, armyOfficerCol] = 'A';
                            }
                            else if (matrix[armyOfficerRow, armyOfficerCol] == 'M')
                            {
                                armyOfficerCol += 2;
                                matrix[armyOfficerRow, armyOfficerCol - 2] = '-';
                                if (RowAndColValidaitInMatrix(armyOfficerRow, armyOfficerCol, armorySize) )
                                {
                                    matrix[armyOfficerRow, armyOfficerCol - 1] = '-'; 
                                    matrix[armyOfficerRow, armyOfficerCol] = 'A';
                                }
                                else
                                {
                                    brakeTheWhile = false;
                                } 
                            }
                        }
                        else
                        {
                            brakeTheWhile = false;
                        }
                        break;
                    default:
                        break;
                }
                PrintMatrix(matrix);
            }
            if (brakeTheWhile)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");  
            }
            else
            {
                Console.WriteLine("I do not need more swords!");
            }
            Console.WriteLine($"The king paid {coinNumColect} gold coins.");
            PrintMatrix(matrix);
        }
        public static bool RowAndColValidaitInMatrix(int row, int col, int matrixSize)
        {
            bool isOut = false;
            if (row >= 0 && row < matrixSize && col >= 0 && col < matrixSize)
            {
                isOut = true;
            }
            return isOut;
        }
        public static void FillMatrix(char[,] matrix, int matrixSize)
        {
            for (int rowI = 0; rowI < matrixSize; rowI++)
            {
                string inputField = Console.ReadLine();
                for (int colI = 0; colI < matrixSize; colI++)
                {
                    matrix[rowI, colI] = inputField[colI];
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
                        Console.Write("");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
