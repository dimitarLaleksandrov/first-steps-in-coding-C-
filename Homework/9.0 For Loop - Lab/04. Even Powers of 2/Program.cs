using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i <= 2; i *= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
