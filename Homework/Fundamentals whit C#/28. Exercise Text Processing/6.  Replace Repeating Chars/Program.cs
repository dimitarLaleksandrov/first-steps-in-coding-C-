using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> result = new List<char>();
            result.Add(input[0]);
            foreach (var charek in input)
            {
                if (charek != result.Last())
                {
                    result.Add(charek);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
