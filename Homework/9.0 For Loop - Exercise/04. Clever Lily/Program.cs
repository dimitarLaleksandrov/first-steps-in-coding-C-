using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double machine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int evenMoney = 0;
            int totalMOney = 0;
            int oddToy = 0;
            for (int i = 1; i <= age ; i++)
            {
                evenMoney += 5;
                if (i %2 == 0)
                {
                    totalMOney += evenMoney - 1;
                }
                else
                {
                    oddToy++;
                }
            }
            totalMOney += oddToy * toyPrice;
            if (totalMOney >= machine)
            {
                Console.WriteLine($"Yes! {totalMOney - machine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {machine - totalMOney:f2}");
            }
        }
    }
}
