using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                decimal moneyNeed = decimal.Parse(Console.ReadLine());
                decimal money = 0m;
                while (money < moneyNeed)
                {
                    money += decimal.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
