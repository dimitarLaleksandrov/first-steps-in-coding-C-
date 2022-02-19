using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            int moveCount = 0;
            while (command != "end")
            {
                moveCount++;
                string[] guesses = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int firstGuess = int.Parse(guesses[0]);
                int secondGuess = int.Parse(guesses[1]);
                if (firstGuess < 0 || secondGuess < 0)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                }
                if (IsInvalidGuess(firstGuess, secondGuess ,elements))
                {
                    int middelOfElements = elements.Count / 2;
                    string elementToAdd = $"-{moveCount}a";
                    elements.Insert(middelOfElements, elementToAdd);
                    elements.Insert(middelOfElements, elementToAdd);
                }
                else if (elements[firstGuess] == elements[secondGuess])
                {
                    string gessElement = elements[firstGuess];
                    elements.Remove(gessElement);
                    elements.Remove(gessElement);
                    //elements.RemoveAll(x => x == gessElement);
                    Console.WriteLine($"Congrats! You have found matching elements - {gessElement}!");
                }
                else if (elements[firstGuess] != elements[secondGuess])
                {
                    Console.WriteLine($"Try again!");
                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moveCount} turns!");
                    break;
                    //return;
                }
                command = Console.ReadLine();
            }
            if (elements.Count > 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine($"{string.Join(" ", elements)}");
            }
        }
        static bool IsInvalidGuess(int firstGuess, int secondGuess, List<string> elements)
        {
            return firstGuess == secondGuess || !IsGessInList(firstGuess, elements) || !IsGessInList(secondGuess, elements);
        }
        static bool IsGessInList(int guess, List<string> elements)
        {
            return guess >= 0 && guess < elements.Count;
        }
    }
}
