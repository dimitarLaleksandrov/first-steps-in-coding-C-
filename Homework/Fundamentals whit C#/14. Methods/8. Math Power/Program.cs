using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            int powerNum = int.Parse(Console.ReadLine());
            ResoltMethod(baseNum, powerNum);
        }
        static double ResoltMethod(double baseNum, int powerNum)
        {
            double num = 1d;
            for (int i = 1; i <= powerNum; i++)
            {
                num *= baseNum;
            }
            Console.WriteLine(num);
            return num;
        }
    }
}
