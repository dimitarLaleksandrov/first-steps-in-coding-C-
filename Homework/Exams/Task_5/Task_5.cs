using System;

namespace Task_5
{
    class Task_5
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int scoreCount = int.Parse(Console.ReadLine());
            string bestPlayerName = playerName;
            int bestPlayerScore = scoreCount;
            if (bestPlayerScore < 10)
            {
                while (playerName != "END")
                {
                    if (bestPlayerScore < scoreCount)
                    {
                        bestPlayerScore = scoreCount;
                        bestPlayerName = playerName;
                    }
                    playerName = Console.ReadLine();
                    if (playerName != "END")
                    {
                        scoreCount = int.Parse(Console.ReadLine());
                    }
                    if (scoreCount >= 10)
                    {
                        bestPlayerName = playerName;
                        bestPlayerScore = scoreCount;
                        break;
                    }
                }
            }
            
            Console.WriteLine($"{bestPlayerName} is the best player!");
            if (bestPlayerScore >= 3)
            {
                Console.WriteLine($"He has scored {bestPlayerScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerScore} goals.");
            }
        }
    }
}
