using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    internal class ActionPrint
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ").ToList();
            Action<string> printName = name => Console.WriteLine(name);
            names.ForEach(printName);
        }
    }
}
