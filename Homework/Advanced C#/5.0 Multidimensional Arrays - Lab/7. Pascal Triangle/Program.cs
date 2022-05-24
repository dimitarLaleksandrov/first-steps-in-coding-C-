using System;
using System.Numerics;

namespace _7._Pascal_Triangle
{
    internal class PascalTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger[][] triangal = new BigInteger[n][]; 
            for (int row = 0; row < n; row++)
            {
                triangal[row] = new BigInteger[row + 1];
                triangal[row][0] = 1;
                for (int col = 1; col < row; col++)
                {
                    triangal[row][col] = triangal[row - 1][col - 1] + triangal[row - 1][col];
                }
                triangal[row][row] = 1;
            }
            for (int row = 0; row < triangal.Length; row++)
            {
                Console.WriteLine(String.Join(" ", triangal[row]));
            }
        }
    }
}
