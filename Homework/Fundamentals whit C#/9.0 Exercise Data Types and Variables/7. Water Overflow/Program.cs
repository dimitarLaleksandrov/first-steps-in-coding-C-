using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tankCapacity = 255;
            int addedLiters = 0;
            int litersLeft = tankCapacity;
            int numOfLine = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOfLine; i++)
            {
                int waterQuantitie = int.Parse(Console.ReadLine());
                addedLiters += waterQuantitie;
                if (waterQuantitie > litersLeft)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litersLeft += waterQuantitie;
                    addedLiters -= waterQuantitie;
                }
                litersLeft -= waterQuantitie;
            }
            Console.WriteLine(addedLiters);
        }
    }
}
