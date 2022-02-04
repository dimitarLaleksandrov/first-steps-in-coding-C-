using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonus = 0;
            if(points <= 100)
            {
                bonus = bonus + 5;
            }
            else if(points <= 1000)
            {
                bonus = bonus + (points * 0.20);
            }
            else
            {
                bonus = bonus + (points * 0.1);
            }
            if(points % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if(points % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);

        }
    }
}
