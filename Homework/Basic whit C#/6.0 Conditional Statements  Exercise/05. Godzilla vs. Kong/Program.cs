using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieDudget = double.Parse(Console.ReadLine());
            double numOfExtras = double.Parse(Console.ReadLine());
            double clothOnePrice = double.Parse(Console.ReadLine());
            double decor = movieDudget * 0.10;
            double clothPrice = clothOnePrice * numOfExtras;
            if(numOfExtras > 150)
            {
                clothPrice = clothPrice - (clothPrice * 0.10);
            }
            double moneyNeed = Math.Abs((decor + clothPrice) - movieDudget);
            if((decor + clothPrice) > movieDudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeed:f2} leva more.");
            }
            else if((decor + clothPrice) <= movieDudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyNeed:f2} leva left.");
            }
        }
    }
}
