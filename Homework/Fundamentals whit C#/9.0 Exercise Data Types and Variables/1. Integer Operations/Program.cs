using System;

namespace _1._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int furstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int therdNum = int.Parse(Console.ReadLine());
            int foreNum = int.Parse(Console.ReadLine());
            int furstPerform = furstNum + secondNum;
            int secondPerform = furstPerform / therdNum;
            int therdPerform = secondPerform * foreNum;
            Console.WriteLine(therdPerform);
        }
    }
}
