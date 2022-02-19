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
            List<int> exitPrint = SortedListForPrinting(firstList, secondList, betweenFirstNum, betweenLastNum);
            Console.WriteLine(string.Join(" ", exitPrint));
        }
        static List<int> SortedListForPrinting(List<int> firstList, List<int> secondList, int betweenFirstNum, int betweenLastNum)
        {
            List<int> mixedList = new List<int>();
            List<int> lastPrintList = new List<int>();
            for (int i = 0; i <= (firstList.Count + 2) + (secondList.Count + 2); i++)
            {
                mixedList.Add(firstList[0]);
                firstList.RemoveAt(0);
                mixedList.Add(secondList[secondList.Count - 1]);
                secondList.RemoveAt(secondList.Count - 1);
            }
            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > betweenFirstNum && mixedList[i] < betweenLastNum)
                {
                    lastPrintList.Add(mixedList[i]);
                }
                lastPrintList.Sort();
            }
            return lastPrintList;
        }
    }
}
