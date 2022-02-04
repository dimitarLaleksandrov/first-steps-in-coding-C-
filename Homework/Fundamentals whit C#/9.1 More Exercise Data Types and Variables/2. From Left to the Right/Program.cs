using System;

namespace _2._From_Left_to_the_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int intput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= intput; i++)
            {
                string numbers = Console.ReadLine();
                char space = ' ';
                string[] splitNumber = numbers.Split(space);
                long leftNum = long.Parse(splitNumber[0]);
                long rightNum = long.Parse(splitNumber[1]);
                long biggerNum = rightNum;
                if (leftNum > rightNum)
                {
                    biggerNum = leftNum;
                }
                long sumOfDigits = 0;
                while (biggerNum != 0)
                {
                    sumOfDigits += biggerNum % 10;
                    biggerNum /= 10;
                }
                Console.WriteLine($"{Math.Abs(sumOfDigits)}");
            }
        }
    }
}
