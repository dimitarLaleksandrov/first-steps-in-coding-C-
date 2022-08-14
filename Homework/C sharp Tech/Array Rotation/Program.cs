using System;
using System.Linq;

namespace Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int firstNum = numberArray[0];
                for (int j = 0; j < numberArray.Length - 1; j++)
                {
                    numberArray[j] = numberArray[j + 1];
                }
                numberArray[numberArray.Length - 1] = firstNum;
            }
            Console.WriteLine(string.Join(" ", numberArray));
        }
    }
}
