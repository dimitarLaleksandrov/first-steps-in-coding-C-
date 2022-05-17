using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>();
            Array.Reverse(input);
            string[] reversString = input;
            foreach (string str in reversString)
            {
                stack.Push(str);
            }
            int resolt = int.Parse(stack.Pop());
            for (int i = 0; i < stack.Count;)
            {
                string simbol = stack.Pop();
                int num = int.Parse(stack.Pop());
                if (simbol == "+")
                {
                    resolt += num;
                }
                else if (simbol == "-")
                {
                    resolt -= num;
                }
            }
            Console.WriteLine(resolt);
        }
    }
}
