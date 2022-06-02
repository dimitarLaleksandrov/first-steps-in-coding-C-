using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int devisibleNum = int.Parse(Console.ReadLine());
            Predicate<int> removetNums = n => n % devisibleNum == 0;
            Stack<int> endinput = new Stack<int>();
            foreach (var num in inputNums)
            {
                if (!removetNums(num))
                {
                    endinput.Push(num);
                }
            }
            Console.WriteLine(String.Join(" ", endinput));
        }
    }
}
