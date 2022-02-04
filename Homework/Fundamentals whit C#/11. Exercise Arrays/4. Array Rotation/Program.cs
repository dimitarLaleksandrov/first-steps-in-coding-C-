using System;
using System.Linq;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotaishans = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rotaishans ; i++)
            {
                int furstDigit = input[0];
                for (int j = 0; j <= input.Length - 2; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = furstDigit;
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
