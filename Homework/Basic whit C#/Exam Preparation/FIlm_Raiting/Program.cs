
 using System;

namespace FIlm_Raiting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFilms = int.Parse(Console.ReadLine());
            string nameOfFIlmWhitHiestRaiting = "";
            decimal bestRaiting = 0;
            decimal lowestRaiting = 0;
            string lowestRaitingFilm = "";
            decimal allRaiting = 0;
            int movieCounter = 0;
            while (movieCounter < numberOfFilms)
            { 
                string moveyName = Console.ReadLine();
                decimal raiting = decimal.Parse(Console.ReadLine());
                if (bestRaiting < raiting)
                {   
                    bestRaiting = raiting;
                    nameOfFIlmWhitHiestRaiting = moveyName;    
                }
                if (lowestRaiting > raiting || lowestRaiting == 0)
                {
                    lowestRaiting = raiting;
                    lowestRaitingFilm = moveyName;
                }
                allRaiting += raiting;
                movieCounter++;
            }
            decimal averageRaiting = allRaiting / numberOfFilms;
            Console.WriteLine($"{nameOfFIlmWhitHiestRaiting} is with highest rating: {bestRaiting:f1}");
            Console.WriteLine($"{lowestRaitingFilm} is with lowest rating: {lowestRaiting:f1}");
            Console.WriteLine($"Average rating: {averageRaiting:f1}");
        }
    }
}
