using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.__Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] numberCharArr = Console.ReadLine().TrimStart('0').ToCharArray().Reverse().ToArray();                         
            int multiplayer = int.Parse(Console.ReadLine());
            List<int> multiplicatinList = new List<int>();
            if (multiplayer == 0)
            {
                Console.WriteLine(0);
                return;
            }  
            int remainder = 0;
            foreach (var digitChar in numberCharArr)
            {
                int digit = int.Parse(digitChar.ToString());
                int result = digit * multiplayer + remainder;
                remainder = result / 10;
                result = result % 10;
                multiplicatinList.Add(result);
            }
            if (remainder > 0)
            {
                multiplicatinList.Add(remainder);
            }
            multiplicatinList.Reverse();
            Console.WriteLine(string.Join(string.Empty, multiplicatinList));
        }
    }
}
