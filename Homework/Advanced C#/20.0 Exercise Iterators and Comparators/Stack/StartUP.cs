using System;
using System.Linq;

namespace Stack
{
    public class StartUP
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END")
                {
                    break;
                }
                else if(input[0] == "Push")
                {
                    stack.Push(input.Skip(1).Select(e => e.Split(",", StringSplitOptions.RemoveEmptyEntries).First()).ToArray());
                }
                else if (input[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);

                    }
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
