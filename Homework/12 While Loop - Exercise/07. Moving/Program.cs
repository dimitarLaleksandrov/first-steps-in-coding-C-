using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthSpace = int.Parse(Console.ReadLine());
            int lengthSpace = int.Parse(Console.ReadLine());
            int heightSpace = int.Parse(Console.ReadLine());
            int allCubicMeters = widthSpace * lengthSpace * heightSpace;
            int cubicMeters = 0;
            while (cubicMeters < allCubicMeters)
            {
                string numberOfBox = Console.ReadLine();
                if (numberOfBox == "Done" && cubicMeters < allCubicMeters)
                {
                    int freeCubicMeters = allCubicMeters - cubicMeters;
                    Console.WriteLine($"{freeCubicMeters} Cubic meters left.");
                    break;
                }
                int number = int.Parse(numberOfBox);
                cubicMeters += number;
            }
            if (cubicMeters >= allCubicMeters)
            {
                double noMoreCubic = cubicMeters - allCubicMeters;
                Console.WriteLine($"No more free space! You need {noMoreCubic} Cubic meters more.");
            }
        }
    }
}
