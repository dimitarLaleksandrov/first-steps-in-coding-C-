using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int goal = 10000;
            int allSteps = 0;
            while (goal > allSteps)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    allSteps += lastSteps;
                    break;
                }
                int steps = int.Parse(input);
                allSteps += steps;
            }
            if (allSteps >= goal)
            {
                int stepsLeft = allSteps - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsLeft} steps over the goal!");
            }
            else
            {
                int difarence = goal - allSteps;
                Console.WriteLine($"{difarence} more steps to reach goal.");
            }
        }
    }
}
