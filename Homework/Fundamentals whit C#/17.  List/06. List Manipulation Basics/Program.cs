using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string line = string.Empty;
            while (( line = Console.ReadLine()) != "end")
            {
                string[] input = line.Split();
                switch (input[0])
                { 
                    case "Add":
                        int numberToAdd = int.Parse(input[1]);
                        num.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(input[1]);
                            num.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(input[1]);
                        num.RemoveAt(indexToRemoveAt);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(input[1]);
                        int indexToInsert = int.Parse(input[2]);
                        num.Insert(indexToInsert, numberToInsert);
                        break;
                    default:
                        break;
                } 
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
