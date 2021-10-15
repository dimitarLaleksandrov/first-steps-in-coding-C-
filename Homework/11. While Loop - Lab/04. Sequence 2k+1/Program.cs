using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double printNum =1;
            while (num >= printNum)
            {                
                Console.WriteLine(printNum);
                printNum = printNum * 2 + 1;
            }
        }
    }
}
