using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int validCombo = 0;
            int loopCounter = 0;
            int modifiedLoopCounter = 0;
            for (int x1 = 0; x1 <= n; x1++)
            {
                for (int x2 = 0; x1 + x2 <= n; x2++)
                {
                    for (int x3 = 0; x1 + x2 + x3 <= n; x3++)
                    {
                        if (x1 + x2 + x3 == n)
                        {
                            validCombo++;
                        }
                        modifiedLoopCounter++;
                   }
                }
            }

            validCombo = 0;
            for (int x1 = 0; x1 <= n; x1++)
            {
                for (int x2 = 0; x2 <= n; x2++)
                {
                    for (int x3 = 0; x3 <= n; x3++)
                    {
                        if (x1 + x2 + x3 == n)
                        {
                            validCombo++;
                        }
                        loopCounter++;
                    }
                }
            }
            Console.WriteLine(validCombo);
            Console.WriteLine($"Normal loop: {loopCounter}");
            Console.WriteLine($"Optimized loop: {modifiedLoopCounter}");
            Console.WriteLine($"Difference: {loopCounter - modifiedLoopCounter}");
        }
    }
}
