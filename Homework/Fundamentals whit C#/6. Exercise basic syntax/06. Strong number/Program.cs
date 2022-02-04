using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());          
            for (int i = num; i > 0; i--)
            {
                Console.Write(i);           
            }           
        }
    }
}
