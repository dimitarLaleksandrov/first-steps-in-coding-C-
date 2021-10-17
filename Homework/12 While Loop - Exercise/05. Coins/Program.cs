using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coinsCounter = 0;
            decimal convertedChange = change * 100;
            int cents = (int)convertedChange;
            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    coinsCounter++;
                    cents -= 200;
                }
                else if (cents - 100 >= 0)
                {
                    coinsCounter++;
                    cents -= 100;
                }
                else if (cents - 50 >= 0)
                {
                    coinsCounter++;
                    cents -= 50;
                }
                else if (cents - 20 >= 0)
                {
                    coinsCounter++;
                    cents -= 20;
                }
                else if (cents - 10 >= 0)
                {
                    coinsCounter++;
                    cents -= 10;
                }
                else if (cents - 5 >= 0)
                {
                    coinsCounter++;
                    cents -= 5;
                }
                else if (cents - 2 >= 0)
                {
                    coinsCounter++;
                    cents -= 2;
                }
                else if (cents -1 >= 0)
                {
                    coinsCounter++;
                    cents -= 1;
                }
            }
            Console.WriteLine(coinsCounter);
        }
    }
}
