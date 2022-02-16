using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandIndex = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandIndex[0] == "Add")
                {
                    numbers.Add(int.Parse(commandIndex[1]));
                }
                else if (commandIndex[0] == "Insert")
                {
                    int num = int.Parse(commandIndex[1]);
                    int index = int.Parse(commandIndex[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        numbers.Insert(index, num);
                    }
                }
                else if (commandIndex[0] == "Remove")
                {
                    int index = int.Parse(commandIndex[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }

                }
                else if (commandIndex[0] == "Shift")
                {
                    if (commandIndex[1] == "left")
                    {
                        int counter = int.Parse(commandIndex[2]);
                        int realPreformancCount = counter % numbers.Count;
                        for (int i = 0; i < realPreformancCount; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.Remove(numbers[0]);
                            // int firstElement = numbers.First();
                        }
                    }
                    else if (commandIndex[1] == "right")
                    {
                        int counter = int.Parse(commandIndex[2]);
                        int realPreformancCount = counter % numbers.Count;
                        for (int i = 0; i < realPreformancCount; i++)
                        {
                            //int lastElement = numbers.Last();
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);    
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
