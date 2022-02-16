using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> invitedGests = new List<string>();
            int numberOfCOmmands = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfCOmmands; i++)
            {
                string[] comands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = comands[0];
                if (comands.Length == 3)
                {
                    
                    if (invitedGests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    invitedGests.Add(name);
                }
                else if (comands.Length == 4)
                {
                    if (!invitedGests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    invitedGests.Remove(name);
                }
            }
            for (int i = 0; i < invitedGests.Count; i++)
            {
                Console.WriteLine(invitedGests[i]);
            }          
        }
    }
}
