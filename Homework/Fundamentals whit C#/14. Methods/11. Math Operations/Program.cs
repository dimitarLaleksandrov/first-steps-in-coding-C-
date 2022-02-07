using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            string index = string.Empty;
            double numTwo = 0;
            Calculater(num, index, numTwo);
        }
        static double Calculater(double num, string index, double numTwo)
        {
            double furstNum = int.Parse(Console.ReadLine());
            string operaitor = Console.ReadLine();
            double secondNum = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (operaitor)
            {
                case "+":
                    sum = furstNum + secondNum;
                    break;
                case "-":
                    sum = furstNum - secondNum;
                    break ;
                 case "*":
                     sum = furstNum * secondNum;
                    break;
                case "/":
                    sum = furstNum / secondNum;
                    break;
                default:
                    break;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
