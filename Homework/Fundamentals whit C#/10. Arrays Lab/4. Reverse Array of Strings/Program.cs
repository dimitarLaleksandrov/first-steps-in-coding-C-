using System;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArrays = Console.ReadLine().Split();
            for (int i = inputArrays.Length - 1; i >= 0; i--)
            {
                Console.Write(inputArrays[i] + " ");
            }
            //Array.Reverse(inputArrays);
        }
    }
}
