using System;
using System.Diagnostics;

namespace DemoCompTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10000000;
            Stopwatch w = Stopwatch.StartNew();
            Linear(n);
            Console.WriteLine(w.ElapsedMilliseconds);
        }

        private static long Linear(int n)
        {
            long counter = 0;
            for (int i = 0; i < n; i++)
            {
                counter++;
            }
            return counter;
        }
    }
}
