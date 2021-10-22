using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowNum = int.Parse(Console.ReadLine());
            int bigNum = int.Parse(Console.ReadLine());
            for (int i = lowNum; i <= bigNum ; i++)
            {
                string num = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int k = 0; k < num.Length ; k++)
                {
                    int numDigit = int.Parse(num[k].ToString());
                    if (k % 2 == 0)
                    {
                        evenSum += numDigit;
                    }
                    else
                    {
                        oddSum += numDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
