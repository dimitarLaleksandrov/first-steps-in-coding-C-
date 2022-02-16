using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHandOfCards = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondHandOfCards = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine(CompareTheCards(firstHandOfCards, secondHandOfCards));
        }
        static string CompareTheCards(List<int> firstHand, List<int> secondHand)
        {
            string result = string.Empty;
            while (true)
            {
                if (firstHand[0] > secondHand[0])
                {
                    firstHand.Add(secondHand[0]);
                    firstHand.Add(firstHand[0]);
                }
                else if (secondHand[0] > firstHand[0])
                {
                    secondHand.Add(firstHand[0]);
                    secondHand.Add(secondHand[0]); 
                }
                firstHand.Remove(firstHand[0]);
                secondHand.Remove(secondHand[0]);             
                if (firstHand.Count == 0)
                {
                    int sum = secondHand.Sum();
                    result = $"Second player wins! Sum: {sum}";
                    break;
                }
                else if (secondHand.Count == 0)             
                {
                    int sum = firstHand.Sum();
                    result = $"First player wins! Sum: {sum}";
                    break;
                }
            }
            return result;
        }
    }
}
