using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int furstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;
            
            switch (command)
            {
                case "add":
                    result = Add(furstNum, secondNum);
                    break;
                case "multiply":
                    Multiply(furstNum, secondNum);
                    break;
                case "subtract":
                    Subtract(furstNum, secondNum);
                    break;
                case "divide":
                    Divide(furstNum, secondNum);
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
            static int Add( int furstNum, int secondNum)
            {
                return furstNum + secondNum;
            } 
            static void Multiply(int furstNum, int secondNum)
            {
                Console.WriteLine(furstNum * secondNum);
            }
            static void Subtract(int furstNum, int secondNum)
            {
                Console.WriteLine(furstNum - secondNum);
            }
            static void Divide(int furstNum, int secondNum)
            {
                Console.WriteLine(furstNum / secondNum);
            }

        }
    }
}
