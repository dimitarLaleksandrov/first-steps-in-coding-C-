using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rowsCount][];
            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(' ');
                if (cmd[0] == "END")
                {
                    break;
                }
                else if (cmd[0] == "Add" || cmd[0] == "Subtract")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int val = int.Parse(cmd[3]);
                    if (cmd[0] == "Subtract")
                    {
                        val = -val;
                    }
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += val;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }                
                } 
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            } 
        }
    }
}
