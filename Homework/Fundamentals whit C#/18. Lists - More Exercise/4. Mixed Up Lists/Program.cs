using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Mixed_Up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int betweenFirstNum = 0;
            int betweenLastNum = 0;           
            if (firstList.Count > secondList.Count)
            {
                betweenFirstNum = firstList[firstList.Count - 1];
                betweenLastNum = firstList[firstList.Count - 2];
                firstList.RemoveAt(firstList.Count - 1);
                firstList.RemoveAt(firstList.Count - 1); 
            }
            else if (secondList.Count > firstList.Count)
            {
                betweenFirstNum = secondList[0];
                betweenLastNum = secondList[1];
                secondList.RemoveAt(0);
                secondList.RemoveAt(0);    
            }
            if (betweenFirstNum > betweenLastNum)
            {
                var a = betweenLastNum;
                betweenLastNum = betweenFirstNum;
                betweenFirstNum = a;
            }
            List<int> exitPrint = SortedListForPrinting(firstList, secondList, betweenFirstNum, betweenLastNum);
            Console.WriteLine(string.Join(" ", exitPrint));
        }
        static List<int> SortedListForPrinting(List<int> firstList, List<int> secondList, int betweenFirstNum, int betweenLastNum)
        {
            List<int> mixedList = new List<int>();
            for (int i = 0; i < firstList.Count; i++)
            {
                if (IsInRange(firstList[i], betweenFirstNum, betweenLastNum))
                {
                    mixedList.Add(firstList[i]);
                }
                if (IsInRange(secondList[i], betweenFirstNum, betweenLastNum))
                {
                    mixedList.Add(secondList[i]);
                }
            }
            mixedList.Sort();
            return mixedList;
        }
        static bool IsInRange(int value, int min, int max)
        {
            return value > min && value < max;
        }
    }
}
