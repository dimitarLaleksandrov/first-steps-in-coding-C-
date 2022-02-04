using System;

namespace array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOne = int.Parse(Console.ReadLine());
            char[] arrayOne = new char[lengthOne];
            for (int i = 0; i < lengthOne; i++)
            {
                arrayOne[i] = char.Parse(Console.ReadLine());
            }
            int lengthTwo = int.Parse(Console.ReadLine());
            char[] arrayTwo = new char[lengthOne];
            for (int i = 0; i < lengthTwo; i++)
            {
                arrayTwo[i] = char.Parse(Console.ReadLine());
            }        
        }
    }
}
