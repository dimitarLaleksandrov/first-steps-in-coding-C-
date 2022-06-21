using System;
using System.Linq;

namespace _2._Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrixRow = matrixSize[0];
            var matrixCol = matrixSize[1];
            int[,] garden = new int[matrixRow, matrixCol];
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] flowerCoordinates = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var flowerRow = flowerCoordinates[0];
                var flowerCol = flowerCoordinates[1];
                if(flowerRow < 0 || flowerCol < 0 || flowerRow >= matrixRow || flowerCol >= matrixCol)
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                else
                {
                    var flower = new int[flowerRow, flowerCol];
                    for (int row = 0; row < matrixRow; row++)
                    {
                        for (int col = 0; col < matrixCol; col++)
                        {
                            if (col == flowerCol)
                            {
                                if (garden[row, col] == 0)
                                {
                                    garden[row, col] = 1;
                                }
                                else if(garden[row, col] != garden[flowerRow, flowerCol])
                                {
                                    garden[row, col] += 1;
                                }
                                else
                                {
                                    garden[row, col] += 1;
                                }
                            }
                            else if (row == flowerRow)
                            {
                                if (garden[row, col] == 0)
                                {
                                    garden[row, col] = 1;
                                }
                                else if(garden[row, col] != garden[flowerRow, flowerCol])
                                {
                                    garden[row, col] += 1;
                                }
                                else
                                {
                                    garden[row, col] += 1;
                                }
                            }
                        }  
                    }
                }
            }
            PrintTheMatrix(garden);
        }
        public static void PrintTheMatrix(int[,] matrix)
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
