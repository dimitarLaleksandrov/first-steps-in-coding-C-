using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arayLoop = int.Parse(Console.ReadLine());
            int[] furstArray = new int[arayLoop];
            int[] secondArray = new int[arayLoop];
            for (int i = 1; i <= arayLoop; i++)
            {
                int[] corentArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int furstNum = corentArray[0];
                int secondNum = corentArray[1];
                if (i % 2 != 0)
                {
                    furstArray[i - 1] = furstNum;
                    secondArray[i - 1] = secondNum;
                }
                else
                {
                    furstArray[i - 1] = secondNum;
                    secondArray[i - 1] = furstNum;
                }
            }
            Console.WriteLine(String.Join(" ", furstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}
