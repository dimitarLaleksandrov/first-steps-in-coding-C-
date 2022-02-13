using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = 0;
            int numTwo = 0;
            int numThree = 0;
            TheSmalerNum(numOne, numTwo, numThree);
        }
        static int TheSmalerNum(int numOne, int numTwo, int numThree)
        {

            int furstNum = int.Parse(Console.ReadLine());
            int secontdNum = int.Parse(Console.ReadLine());
            int therdNum = int.Parse(Console.ReadLine());
            int theSmalestNum = 0;
            if (furstNum < secontdNum && furstNum < therdNum)
            {
                theSmalestNum = furstNum;
            }
            else if (secontdNum < therdNum && secontdNum < furstNum)
            {
                theSmalestNum = secontdNum;
            }
            else
            {
                theSmalestNum = therdNum;
            }
            Console.WriteLine(theSmalestNum);
            return theSmalestNum;
        }
    }
}
