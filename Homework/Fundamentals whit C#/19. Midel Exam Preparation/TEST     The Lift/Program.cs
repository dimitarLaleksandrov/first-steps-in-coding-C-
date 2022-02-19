using System;
using System.Linq;

namespace TEST_____The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());

            int[] currentState = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int maxCapacity = 4;
            bool noMorePeople = false;
            for (int i = 0; i < currentState.Length; i++)
            {
                int currentWagon = currentState[i];
                if (waitingPeople - (maxCapacity - currentWagon) == 0)
                {
                    waitingPeople -= maxCapacity - currentWagon;
                    currentState[i] = 4;
                    noMorePeople = true;
                    break;
                }
                else if (waitingPeople - (maxCapacity - currentWagon) < 0)
                {
                    currentState[i] = waitingPeople;
                    waitingPeople = 0;
                    noMorePeople = true;
                    break;
                }
                else
                {
                    waitingPeople -= maxCapacity - currentWagon;
                    currentState[i] = 4;
                }
            }
            bool emptyCabins = false;
            for (int i = 0; i < currentState.Length; i++)
            {
                if (currentState[i] < 4)
                {
                    emptyCabins = true;
                    break;
                }
            }
            if (noMorePeople == true && emptyCabins == true)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", currentState));

            }
            else if (waitingPeople > 0 && emptyCabins == false)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(String.Join(" ", currentState));
            }
            else if (waitingPeople == 0 && emptyCabins == false)
            {
                Console.WriteLine(String.Join(" ", currentState));
            }
        }
    }
}
