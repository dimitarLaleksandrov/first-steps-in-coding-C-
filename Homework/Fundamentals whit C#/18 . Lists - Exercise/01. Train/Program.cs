using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxWagenCapasity = int.Parse(Console.ReadLine());
            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comands = comand.Split(" ");
                if (comands.Length == 1)
                {
                    int passengers = int.Parse(comands[0]);
                    for (int i = 0; i < wagens.Count - 1; i++)
                    {
                        if (wagens[i] + passengers <= maxWagenCapasity)
                        {
                            wagens[i] += passengers;
                            break;
                        }
                    }
                }
                else if (comands[0] == "Add")
                {
                    int addWagens = int.Parse(comands[1]);
                    wagens.Add(addWagens);
                }             
            }
            Console.WriteLine(string.Join(" ", wagens));            
        }
    }
}
