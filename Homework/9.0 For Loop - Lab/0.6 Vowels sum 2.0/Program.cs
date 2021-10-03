using System;

namespace _0._6_Vowels_sum_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int num = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (letter == 'a')
                {

                    num += 1;
                }
                else if (letter == 'e')
                {
                    num += 2;
                }
                else if (letter == 'i')
                {
                    num += 3;
                }
                else if (letter == 'o')
                {
                    num += 4;
                }
                else if (letter == 'u')
                {
                    num += 5;
                }
            }
            Console.WriteLine(num);
        }
    }
}
