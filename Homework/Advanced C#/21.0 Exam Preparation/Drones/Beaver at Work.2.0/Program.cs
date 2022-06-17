using System;
using System.Collections.Generic;

namespace Beaver_at_Work._2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string beaverMark = "B";
            const string fishMark = "F";
            const string dashMark = "-";
            int matrixSize = int.Parse(Console.ReadLine());
            string[,] matrix = new string[matrixSize, matrixSize];
            Dictionary<int, int> beaver = new Dictionary<int, int>();
            Dictionary<int, int> fishesPoint = new Dictionary<int, int>();
            for (int rowi = 0; rowi < matrixSize; rowi++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int coli = 0; coli < matrixSize; coli++)
                {
                    matrix[rowi, coli] = input[coli];
                }
            }
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == beaverMark)
                    {
                        beaver.Add(row, col);
                    }
                }
            }
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == fishMark)
                    {
                        fishesPoint.Add(row, col);
                    }
                }
            }
            int fishCount = fishesPoint.Count;
            var beaverRow = 0;
            var beaverCol = 0;
            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "end" && fishCount > 0)
            {            
                switch (cmd)
                {
                    case "up":
                        foreach (var b in beaver)
                        {
                            if(b.Key == 0)
                            {
                                beaverRow = matrix.Length - 1;
                                beaverCol = b.Value;
                            }
                            else
                            {
                                beaverRow = b.Key -1;
                                beaverCol = b.Value;
                            }  
                        }
                        beaver.Clear();                       
                        beaver.Add(beaverRow, beaverCol);
                        foreach (var fish in fishesPoint)
                        {
                            if(fish.Key == beaverRow)
                            {
                                if(fish.Value == beaverCol)
                                {
                                    fishesPoint.Remove(fish.Key);
                                    fishCount--;
                                    if(beaverRow == 0)
                                    {
                                        beaverRow = matrix.Length - 1;
                                    }
                                    else
                                    {
                                        beaverRow -= 1;
                                    }
                                }
                            }
                        }
                        break;

                    default:
                        break;
                }
            }














            Console.WriteLine(fishCount);
            // matrix prit at the Console
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if( col > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine(" ");
            }
            foreach (var b in beaver)
            {
                Console.WriteLine(b.Key);
                Console.WriteLine(b.Value);
            }
            foreach (var fishes in fishesPoint)
            {
                Console.WriteLine(fishes.Key);
                Console.WriteLine(fishes.Value);
            }
        }
    }
}
