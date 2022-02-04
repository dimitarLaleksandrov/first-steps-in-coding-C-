using System;

namespace _1._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThre = int.Parse(Console.ReadLine());
            int topnum = 0;
            int midelNum = 0;
            int lastNum = 0;
            if (numOne > numTwo && numOne > numThre)
            {
                topnum = numOne;
                if (numTwo > numThre)
                {
                    midelNum = numTwo;
                    lastNum = numThre;
                }
                else
                {
                    midelNum = numThre;
                    lastNum = numTwo;
                }
            }
            if (numTwo > numOne && numTwo > numThre)
            {
                topnum = numTwo;
                if (numOne > numThre)
                {
                    midelNum = numOne;
                    lastNum = numThre;
                }
                else
                {
                    midelNum = numThre;
                    lastNum = numOne;
                }
            }
            if (numThre > numTwo && numThre > numOne)
            {
                topnum = numThre;
                if (numTwo > numOne)
                {
                    midelNum = numTwo;
                    lastNum = numOne;
                }
                else
                {
                    midelNum = numOne;
                    lastNum = numTwo;
                }
            }
            Console.WriteLine(topnum);
            Console.WriteLine(midelNum);
            Console.WriteLine(lastNum);

        }
    }
}
