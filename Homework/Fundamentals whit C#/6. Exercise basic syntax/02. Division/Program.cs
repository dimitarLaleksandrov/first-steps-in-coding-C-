using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = 0;
            if (input % 2 == 0)
            {
                num = 2;
                if (input % 3 == 0)
                {
                    num = 3;
                    if (input % 6 == 0)
                    {
                        num = 6; 
                    }
                }
                if (input % 7 == 0)
                {
                    num = 7;
                }
                if (input % 10 == 0)
                {
                    num = 10;
                }

            }
            else if (input % 3 == 0)
            {
                num = 3;
                if (input % 6 == 0)
                {
                    num = 6;
                }
                else if (input % 7 == 0)
                {
                    num = 7;
                }
                else if (input % 10 == 0)
                {
                    num = 10;
                }
            }
            else if (input % 6 == 0)
            {
                num = 6;
                if (input % 7 == 0)
                {
                    num = 7;
                }
                else if (input % 10 == 0)
                {
                    num = 10;
                }
            }
            else if (input % 7 == 0)
            {
                num = 7;
                if (input % 10 == 0)
                {
                    num = 10;
                }
            }
            else if (input % 10 == 0)
            {
                num = 10;
            }
            if (input % 2 == 0 || input % 3 == 0 || input % 6 == 0 || input % 7 == 0 || input % 10 == 0)
            {
                Console.WriteLine($"The number is divisible by {num}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            
        }
    }
}
