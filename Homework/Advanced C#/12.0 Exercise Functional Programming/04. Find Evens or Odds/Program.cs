using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class FindEvensorOdds
    {
        static void Main(string[] args)
        {
            List<int> numsRaing = Console.ReadLine().Split().Select(int.Parse).ToList();
            string evenOrOdd = Console.ReadLine();
            Predicate<int> Oddnums = num => num % 2 != 0;
            Predicate<int> evenNums = num => num % 2 == 0;
            List<int> nums = new List<int>();
            for (int i = numsRaing[0]; i <= numsRaing[1]; i++)
            {
                if (evenOrOdd == "odd")
                {
                    if (Oddnums(i))
                    {
                        nums.Add(i);
                    }
                }
                else if (evenOrOdd == "even")
                {
                    if (evenNums(i))
                    {
                        nums.Add(i);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
