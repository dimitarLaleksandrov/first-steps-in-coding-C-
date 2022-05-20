using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rowCount = dimensions[0];
            int colCount = dimensions[1];
            int[,] matrix = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            long maxSum = long.MinValue;
            string bestMatrix = " ";
            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < colCount -1; j++)
                {
                    long sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j ] + matrix[i + 1, j  +1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestMatrix = matrix[i, j] + " " + matrix[i, j + 1] +"\r\n" + matrix[i + 1, j] + " " + matrix[i + 1, j + 1];
                    }
                }
            }
            Console.WriteLine(bestMatrix);
            Console.WriteLine(maxSum);
        }
    }
}
