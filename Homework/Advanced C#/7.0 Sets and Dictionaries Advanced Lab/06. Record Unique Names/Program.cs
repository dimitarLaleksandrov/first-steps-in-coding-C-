using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());
            HashSet<string> strings = new HashSet<string>();
            for (int i = 1; i <= numberOfNames; i++)
            {
                string name = Console.ReadLine();
                strings.Add(name);
            }
            foreach (string name in strings)
            {
                Console.WriteLine(name);
            }
        }
    }
}
