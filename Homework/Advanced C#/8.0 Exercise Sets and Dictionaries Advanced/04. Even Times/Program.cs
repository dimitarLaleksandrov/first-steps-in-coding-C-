using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class EvenTimes
    {
        static void Main(string[] args)
        {
            int loopNums = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 1; i <= loopNums; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 1);
                }
                else
                {
                    numbers[num]++;
                }
            }
            Console.WriteLine(numbers.First(entry => entry.Value % 2 == 0).Key);
        }
    }
}
