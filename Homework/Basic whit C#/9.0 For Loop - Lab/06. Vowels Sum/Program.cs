using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int num = 0;
            for (int i = 0; i < text.Length; ++i)
            {
                char symbol = text[i];
                switch (symbol)
                {
                    case 'a':
                        num += 1;
                        break;
                    case 'e':
                        num += 2;
                        break;
                    case 'i':
                        num += 3;
                        break;
                    case 'o':
                        num += 4;
                        break;
                    case 'u':
                        num += 5;
                        break; 
                } 
            }
            Console.WriteLine(num);
        }
    }
}
