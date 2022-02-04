using System;

namespace пресмятания
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            var second = num1 + num2 + num3;
            var min = 0.0;
            if (second >=60) 
            {
                min = min + 1;
                second = second - 60;


            }
            if (second >= 60)
            {
                min = min + 1;
                second = second - 60;


            }
            if(second <= 10)
            {
                Console.WriteLine(min + ":0" + second);
            }
            else
            {
                Console.WriteLine(min + ":" + second);
            }
            





        }
    }
}
