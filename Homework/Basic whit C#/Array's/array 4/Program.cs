using System;

namespace array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];
            int bestLen = 0;
            int counter = 1;
            int bestStart = 0;
            for (int i = 0; i < lenght; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    if (array[i] == array[i -1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > bestLen)
                    {
                        bestLen = counter;
                        bestStart = i + 1 - bestLen;
                    }
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write($"{array[i]} , ");
            }
        }
    }
}
