using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] ladyBugsJumps = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] field = new int[size];
            for (int i = 0; i < size; i++)
            {
                if (ladyBugsJumps.Contains(i))
                {
                    field[i] = 1;
                }
            }
            string comand = String.Empty;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandArgument = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int startIndex = int.Parse(comandArgument[0]);
                string direction = comandArgument[1];
                int fly = int.Parse(comandArgument[2]);
                if (startIndex < 0 || startIndex >= field.Length)
                {
                    continue;
                }
                if (field[startIndex] == 0)
                {
                    continue;
                }
                int nextIndex = startIndex;
                field[startIndex] = 0;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += fly;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= fly;
                    }
                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }
                    if (field[nextIndex] == 0)
                    {
                        break;
                    }
                }
                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
