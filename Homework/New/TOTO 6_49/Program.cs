using System;

namespace TOTO_6_49
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal counter = 0m;
            for (int i = 1; i <= 44; i++)
            {
                for (int j = i + 1; j <= 45; j++)
                {
                    for (int k = j + 1; k <= 46 ; k++)
                    {
                        for (int h = k + 1; h <= 47; h++)
                        {
                            for (int g = h + 1; g <= 48 ; g++)
                            {
                                for (int n = g +  1; n <= 49 ; n++)
                                {
                                    counter++;
                                }
                            }

                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
