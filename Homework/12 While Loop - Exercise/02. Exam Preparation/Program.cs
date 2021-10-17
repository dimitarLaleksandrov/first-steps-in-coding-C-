using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minRate = 4;
            int tasks = int.Parse(Console.ReadLine());
            string problem = Console.ReadLine();
            string lastProblem = "";
            int badCounter = 0;
            int sum = 0;
            int allSum = 0;
            while (problem != "Enough")
            {
                int evaluation = int.Parse(Console.ReadLine());
                sum++;
                allSum += evaluation;
                if (evaluation <= minRate)
                {
                    badCounter++;
                    if (badCounter == tasks)
                    {
                        break;
                    }
                   
                }
                lastProblem = problem;
                problem = Console.ReadLine();
            }

            if (problem == "Enough")
            {
                double avaregScore = 1.0 * allSum / sum;
                Console.WriteLine($"Average score: {avaregScore:f2}");
                Console.WriteLine($"Number of problems: {sum}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badCounter} poor grades.");
            }
        } 
    }
}
