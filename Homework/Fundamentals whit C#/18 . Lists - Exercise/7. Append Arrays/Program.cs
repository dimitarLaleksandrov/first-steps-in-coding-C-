using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();
            for (int i = input.Count -1; i >= 0; i--)
            {
                var curentList = input[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in curentList)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
