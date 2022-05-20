using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            (int rowCount, int colCount) = (dimensions[0], dimensions[1]);
            int[,] matrix = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            long[] colSums = new long[colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    colSums[j] += matrix[i, j];
                }
            }
            for (int i = 0; i < colCount; i++)
            {
                Console.WriteLine(colSums[i]);
            }
        }
    }
}
