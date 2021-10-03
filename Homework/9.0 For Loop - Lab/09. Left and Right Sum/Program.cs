using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int furstSum = 0;
            int secondSum = 0;
            for (int iOne = 1; iOne <= n ; iOne++)
            {
               int numOne = int.Parse(Console.ReadLine());
                furstSum += numOne;
            }
            for (int iTwo = 1; iTwo <= n; iTwo++)
            {
                int numTwo = int.Parse(Console.ReadLine());
                secondSum += numTwo;
            }
            if (furstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {furstSum}");
            }
            else
            {
                int diff = Math.Abs(furstSum - secondSum); 
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
