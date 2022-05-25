using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class JaggedArrayManipulator
    {
        static void Main(string[] args)
        {
            int rowls = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rowls][];
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }
            for (int row = 0; row < jaggedArray.GetLength(0) - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    jaggedArray[row] = jaggedArray[row].Select(el => el * 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = jaggedArray[row].Select(el => el / 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(el => el / 2).ToArray();
                }
            }
            string cmd = "";
            while ((cmd = Console.ReadLine()) != "End")
            {
                int row = int.Parse(cmd.Split()[1]);
                int col = int.Parse(cmd.Split()[2]);
                int value = int.Parse(cmd.Split()[3]);
                if (cmd.StartsWith("Add"))
                {
                    if (row >= 0 && row < rowls && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value; 
                    }
                }
                else if (cmd.StartsWith("Subtract"))
                {
                    if (row >= 0 && row < rowls && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", row));
            }   
        }
    }
}
