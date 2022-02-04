using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double countP1 = 0.0;
            double countP2 = 0.0;
            double countP3 = 0.0;
            double countP4 = 0.0;
            double countP5 = 0.0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    countP1++; 
                }
                else if (number < 400)
                {
                    countP2++;
                }
                else if (number < 600)
                {
                    countP3++;
                }
                else if (number < 800)
                {
                    countP4++;
                }
                else if (number >= 800)
                {
                    countP5++;
                }
            }
            double precentP1 = countP1 / n * 100;
            double precentP2 = countP2 / n * 100;
            double precentP3 = countP3 / n * 100;
            double precentP4 = countP4 / n * 100;
            double precentP5 = countP5 / n * 100;
            Console.WriteLine($"{precentP1:f2}%");
            Console.WriteLine($"{precentP2:f2}%");
            Console.WriteLine($"{precentP3:f2}%");
            Console.WriteLine($"{precentP4:f2}%");
            Console.WriteLine($"{precentP5:f2}%");
        }
    }
}
