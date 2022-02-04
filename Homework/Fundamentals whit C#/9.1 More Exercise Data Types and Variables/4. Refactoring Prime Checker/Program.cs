using System;

namespace _4._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int loop = 2; loop <= number; loop++)
            {
                string flag = "true";
                for (int loopTwo = 2; loopTwo < loop; loopTwo++)
                {
                    if (loop % loopTwo == 0)
                    {
                        flag = "false";
                        break;
                    }
                }
                Console.WriteLine($"{loop} -> {flag}");
            }

        }
    }
}
