using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int therdNum = int.Parse(Console.ReadLine());
            int sum = CombineOfFurstAndSecondNum(furstNum, secondNum);
            Console.WriteLine(Resolt(therdNum, sum));
        }
        static int CombineOfFurstAndSecondNum(int furst, int second)
        {
            int sum = furst + second;
            return sum;
        }
        static int Resolt(int therdNum, int sum)
        {
            int resolt = sum - therdNum;
            return resolt;
        }
    }
}
