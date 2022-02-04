using System;

namespace _01._Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 7; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }

                i++;
            }

            int n = 7;
            while (n < 1000)
            {
                if (n % 10 == 7)
                {
                    Console.WriteLine(n);
                }

                n++;
            }
        }
    }
}
