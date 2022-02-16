using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = string.Empty;
            while((command = Console.ReadLine()) != "end")
            {
                string[] comands = command.Split(' ');
                if (comands[0] == "Delete")
                {
                    int deletedElements = int.Parse(comands[1]);
                    input.RemoveAll(x => x == deletedElements);
                }
                else if (comands[0] == "Insert")
                {
                    int index = int.Parse(comands[2]);
                    int insertedNum = int.Parse(comands[1]);
                    input.Insert(index, insertedNum);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
