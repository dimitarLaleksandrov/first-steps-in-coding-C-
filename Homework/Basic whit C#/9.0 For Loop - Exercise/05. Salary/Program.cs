using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int facebook = 0;
            int instagram = 0;
            int reddit = 0;
            int tabNum = int.Parse(Console.ReadLine());
            double payment = double.Parse(Console.ReadLine());
            double fines = 0.0;
            for (int i = 1; i <= tabNum; i++)
            {
                string webName = Console.ReadLine();
                if (webName == "Facebook")
                {
                    facebook+= 150;
                }
                else if (webName == "Instagram")
                {
                    instagram+= 100;
                }
                else if (webName == "Reddit")
                {
                    reddit+= 50;
                }
            }
            fines = facebook + instagram + reddit;
            if (payment <= fines)
            {
                Console.WriteLine($"You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{payment - fines:f0}");
            }
        }
    }
}
