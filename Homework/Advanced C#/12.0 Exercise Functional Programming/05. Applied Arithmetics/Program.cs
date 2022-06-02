using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, List<int>> add = list => list.Select(num => num += 1).ToList();
            Func<List<int>, List<int>> multiply = list => list.Select(num => num *= 2).ToList();
            Func<List<int>, List<int>> subtract = list => list.Select(num => num -= 1).ToList();
            Action<List<int>> pritn = list => Console.WriteLine(String.Join(" ", nums));
            string cmd = " ";
            while ((cmd = Console.ReadLine()) != "end")
            {
                switch (cmd)
                {
                    case "add":
                        nums = add(nums);
                        break;
                    case "multiply":
                        nums = multiply(nums);
                        break;
                    case "subtract":
                        nums = subtract(nums);
                        break;
                    case "print":
                        pritn(nums);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
