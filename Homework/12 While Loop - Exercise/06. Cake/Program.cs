using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthPiece = int.Parse(Console.ReadLine());
            int lengthPiece = int.Parse(Console.ReadLine());
            double wholeCake = widthPiece * lengthPiece;
            double cakeCounter = 0;
            while (wholeCake > cakeCounter)
            {
                string cakePiece = Console.ReadLine();
                if (cakePiece == "STOP")
                {
                    double cakeLeft = wholeCake - cakeCounter;
                    Console.WriteLine($"{cakeLeft} pieces are left.");
                    break;
                }
                int cake = int.Parse(cakePiece);
                cakeCounter += cake;
            }
            double needMoreCake = cakeCounter - wholeCake;
            if (cakeCounter > wholeCake)
            {
                Console.WriteLine($"No more cake left! You need {needMoreCake} pieces more.");
            }
        }
    }
}
