using System;

namespace _1_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int kmTravled = int.Parse(Console.ReadLine());
            string dayOrNightTariff = Console.ReadLine();
            if (kmTravled < 20)
            {
                if (dayOrNightTariff == "day")
                {
                    Console.WriteLine((kmTravled * 0.79) + 0.70);
                }
                else
                {
                    Console.WriteLine((kmTravled * 0.90) + 0.70);
                }
            }
            else if (kmTravled >= 20 && kmTravled < 100)
            {
                Console.WriteLine(kmTravled * 0.09);
            }
            else
            {
                Console.WriteLine(kmTravled * 0.06);
            } 
        }
    }
}
