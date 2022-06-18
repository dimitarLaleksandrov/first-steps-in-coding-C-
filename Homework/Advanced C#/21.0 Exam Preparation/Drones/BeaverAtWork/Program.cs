using System;
using System.Collections.Generic;
using System.Linq;

namespace BeaverAtWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfPond = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeOfPond, sizeOfPond];
            Stack<char> brances = new Stack<char>();
            for (int rowi = 0; rowi < sizeOfPond; rowi++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int coli = 0; coli < input.Length; coli++)
                {
                    matrix[rowi, coli] = input[coli][0];
                }                           
            }
            (int row, int col) = FindBeaberLocation(matrix);
            int totalBrancesCount = CalcolatTotalBrancescount(matrix);
            int bramchesLeft = totalBrancesCount;
            while (true)
            {
                
                string cmd = Console.ReadLine();
                if (cmd == "end")
                {
                    break;
                }
                if (bramchesLeft == 0)
                {
                    break;
                }
                if (cmd == "up")
                {
                    MoveTo(row - 1, col, cmd);
                }
                else if (cmd == "down")
                {
                    MoveTo(row + 1, col, cmd);
                }
                else if (cmd == "left")
                {
                    MoveTo(row, col - 1, cmd);
                }
                else if (cmd == "left")
                {
                    MoveTo(row, col + 1, cmd);
                }
                else
                {
                    Console.WriteLine("Invalid command: " + cmd);
                    continue;
                }   
            }
            if (bramchesLeft == 0)
            {
                Console.WriteLine($"The Beaver successfully collect {totalBrancesCount} wood branches: {string.Join(",", brances)}");
                PrintMatris(matrix);
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {bramchesLeft} branches left.");
                PrintMatris(matrix);
            }
            void MoveTo(int newRow, int newCol, string cmd)
            {
                if (newRow > 0 || newRow >= sizeOfPond || newCol > 0 || newCol >= sizeOfPond)
                {
                    if (brances.Count > 0)
                    {
                        brances.Pop();
                        return;
                    }
                }
                if (char.IsLower(matrix[newRow, newCol]))
                {
                    brances.Push(matrix[newRow, newCol]);
                    matrix[row, col] = '-';
                    matrix[newRow, newCol] = 'B';
                    row = newRow;
                    col = newCol;
                    bramchesLeft--;
                    return;
                }
                if (matrix[newRow, newCol] == 'F')
                {
                    if (cmd == "up")
                    {
                        if( newRow != 0)
                        {
                            newRow = 0;
                        }
                        else
                        {
                            newRow = sizeOfPond -1;
                        }
                    }
                    if (cmd == "down")
                    {
                        if (newRow != sizeOfPond - 1)
                        {
                            newRow = sizeOfPond - 1;
                        }
                        else
                        {
                            newRow = 0;
                        }
                    }
                    if (cmd == "left")
                    {
                        if (newCol != 0)
                        {
                            newCol = 0;
                        }
                        else
                        {
                            newCol = sizeOfPond - 1;
                        }
                    }
                    if (cmd == "right")
                    {
                        if (newRow != sizeOfPond - 1)
                        {
                            newRow = sizeOfPond - 1;
                        }
                        else
                        {
                            newRow = 0;
                        }
                    }
                    matrix[row, col] = '-';
                    matrix[newRow, newCol] = 'B';
                    row = newRow;
                    col = newCol;
                    return;
                }
            }
        }
        private static void PrintMatris(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static int CalcolatTotalBrancescount(char[,] matrix)
        {
            int brancesCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (char.IsLower(matrix[row, col]))
                    {
                        brancesCount++;
                    }
                }
            }
            return brancesCount;
        }
        static (int row, int col) FindBeaberLocation(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        return (row, col);
                    }
                }
            }
            throw new Exception("Beaver not found int the matrix!");
        }
    }
}
