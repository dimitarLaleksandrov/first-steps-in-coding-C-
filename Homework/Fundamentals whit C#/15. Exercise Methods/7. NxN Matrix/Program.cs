using System;

namespace _7._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixNum = int.Parse(Console.ReadLine());
            Matrix(matrixNum);
        }
        static int Matrix(int matrixNum)
        {
            for (int i = 0; i < matrixNum; i++)
            {
                for (int j = 0; j < matrixNum ; j++)
                {
                    Console.Write(matrixNum + " ");
                }
                Console.WriteLine();
            }
            return matrixNum;
        }
    }
}
