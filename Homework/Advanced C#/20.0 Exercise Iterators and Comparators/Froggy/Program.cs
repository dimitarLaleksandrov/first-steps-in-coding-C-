using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] filds = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //Stack<int> startFild = new Stack<int>();
            //List<int> endFild = new List<int>();
            //for (int i = 0; i < filds.Length; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        endFild.Add(filds[i]);
            //    }
            //    else
            //    {
            //        startFild.Push(filds[i]); 
            //    }
            //}
            //Console.Write(string.Join(", ", endFild));
            //Console.Write(", ");
            //Console.Write(string.Join(", ", startFild));
            var lake = new Lake(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
