using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maiNum = int.MaxValue;
            while (input != "Stop")
            {
                int num = int.Parse(input);
                input = Console.ReadLine();
                if (num < maiNum)
                {
                    maiNum = num;
                }
            }
            Console.WriteLine(maiNum);
        }
    }
}
