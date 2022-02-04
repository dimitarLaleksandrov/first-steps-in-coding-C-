using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int primeNum = 0;
            int nonPrimeNum = 0;
            while (num != "stop")
            {
                int numDigit = int.Parse(num);
                if (numDigit < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;
                    for (int i = 1; i <= numDigit ; i++)
                    {
                        if (numDigit % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        primeNum += numDigit;
                    }
                    else
                    {
                       nonPrimeNum += numDigit;
                    }
                }
                num = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNum}");
        }
    }
}
