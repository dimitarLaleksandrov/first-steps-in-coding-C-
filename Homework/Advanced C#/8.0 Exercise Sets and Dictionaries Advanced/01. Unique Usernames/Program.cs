﻿using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    internal class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int forNumber = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 1; i <= forNumber; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            //Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}