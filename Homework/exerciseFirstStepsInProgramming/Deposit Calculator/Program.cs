using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var depositSum = double.Parse(Console.ReadLine());
            var timeOfTheDeposit = double.Parse(Console.ReadLine());
            var annualInterestRate = double.Parse(Console.ReadLine());
            var sum = depositSum + timeOfTheDeposit * depositSum * annualInterestRate / 100.0 / 12;
            Console.WriteLine(sum);

        }
    }
}
