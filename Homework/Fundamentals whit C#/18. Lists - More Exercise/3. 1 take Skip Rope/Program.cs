using System;
using System.Collections.Generic;

namespace _3._1_take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> digits = new List<int>();
            List<string> str = new List<string>();

            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    digits.Add(int.Parse(item.ToString()));
                }
                else
                {
                    str.Add(item.ToString());
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            List<string> result = new List<string>();
            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }
            int take = 0;
            int skip = 0;
            int from = 0;
            int to = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                take = takeList[i];
                from = skip;
                to = from + take;
                if (to > str.Count)
                {
                    to = str.Count;
                }
                for (int j = from; j < to; j++)
                {
                    result.Add(str[j]);
                }
                skip += skipList[i] + take;

            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
