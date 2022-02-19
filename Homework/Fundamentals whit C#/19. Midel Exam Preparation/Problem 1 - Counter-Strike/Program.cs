using System;

namespace Problem_1___Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startEnergy = int.Parse(Console.ReadLine());
            string distance = Console.ReadLine();
            int counter = 0;
            int winCounter = 0;
            int energyLeft = startEnergy;
            bool ifGameIsEnd = false;
            while (distance != "End of battle")
            {
                int energy = int.Parse(distance);
                if (energyLeft >= energy)
                {
                    energyLeft -= energy;
                    counter++;
                    winCounter++;
                    if (winCounter == 3)
                    {
                        energyLeft += counter;
                        winCounter = 0;
                    }
                }
                else if (energyLeft < energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energyLeft} energy");
                    ifGameIsEnd = true;
                    break;
                }
                distance = Console.ReadLine();
            }
            if (!ifGameIsEnd)
            {
                Console.WriteLine($"Won battles: {counter}. Energy left: {energyLeft}");
            }  
        }
    }
}
