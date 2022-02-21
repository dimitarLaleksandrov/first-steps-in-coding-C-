using System;

namespace TEST_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheAdventure = int.Parse(Console.ReadLine());
            int numOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());
            double totalWater = dayOfTheAdventure * numOfPlayers * waterPerDay;
            double totalFood = dayOfTheAdventure * numOfPlayers * foodPerDay;
            double energyLostOfAllEnegy = groupEnergy;
            int dayCounter = 1;
            double waterLeft = totalWater;
            double foodLeft = totalFood;
            for (int i = 1; i <= dayOfTheAdventure; i++)
            {
                double energyLost = double.Parse(Console.ReadLine());
                energyLostOfAllEnegy -= energyLost;
                if (energyLostOfAllEnegy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {foodLeft:f2} food and {waterLeft:f2} water.");
                    return;
                }
                if (dayCounter % 2 == 0)
                {
                    energyLostOfAllEnegy += (energyLostOfAllEnegy * 0.05);
                    waterLeft -= (waterLeft * 0.30);
                }
                if (dayCounter % 3 == 0)
                {
                    foodLeft -= (foodLeft / numOfPlayers);
                    energyLostOfAllEnegy += (energyLostOfAllEnegy * 0.10);
                }             
                dayCounter++;
            }
            if (energyLostOfAllEnegy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energyLostOfAllEnegy:f2} energy!");
            } 
        }
    }
}
