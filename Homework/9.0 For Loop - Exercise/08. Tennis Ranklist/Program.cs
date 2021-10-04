using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentNum = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double wStage = 0;
            double fStage = 0;
            double sfStage = 0;
            double finalPoint = 0;
            double averagePoints = 0;
            double percentWin = 0.0;
            double stageOfWin = 0; 
            for (int i = 0; i < tournamentNum; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    stageOfWin++;
                    wStage+= 2000;
                }
                else if (stage == "F")
                {
                    fStage+= 1200;
                }
                else if (stage == "SF")
                {
                    sfStage+= 720;
                }
            }
            finalPoint = wStage + fStage + sfStage + startPoints;
            averagePoints = Math.Floor((wStage + fStage + sfStage) / tournamentNum);
            percentWin = (stageOfWin / tournamentNum) * 100;
            Console.WriteLine($"Final points: {finalPoint}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWin:f2}%");
        }
    }
}
