using System;

namespace Fun_Play_Whit_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLetters = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numLetters; i++)
            {
                char furst = (char)(i);
                for (int j = 1; j <= numLetters; j++)
                {
                    char second = (char)(j);
                    for (int k = 1; k <= numLetters; k++)
                    {
                        char therd = (char)(k);
                        Console.WriteLine($"{furst}{second}{therd}");
                    }
                }
            }
        }
    }
}
