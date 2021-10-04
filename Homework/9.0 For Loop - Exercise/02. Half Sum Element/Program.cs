using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            for (int i = 1; i <= num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            int minusMaxNum = sum - maxNumber;
            if (maxNumber == minusMaxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int diff = Math.Abs(maxNumber - minusMaxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
