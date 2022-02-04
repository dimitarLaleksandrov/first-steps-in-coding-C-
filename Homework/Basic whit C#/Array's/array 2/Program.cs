using System;

namespace array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[numOne];
            for (int i = 0; i < numOne; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            int numTwo = int.Parse(Console.ReadLine());
            int[] arrayTwo = new int[numTwo];
            for (int i = 0; i < numTwo; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }
            if (numOne == numTwo)
            {
                for (int i = 0; i < numOne; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        Console.WriteLine("equal");
                    }
                    else
                    {
                        Console.WriteLine("Not equal");
                    }
                }
            }
            else
            {
                Console.WriteLine("Not equal !!");
            }
        }
    }
}
