using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commands[0] != "End")
            {
                int index = int.Parse(commands[1]);
                int power = int.Parse(commands[2]);
                switch (commands[0])
                {
                    case "Shoot":
                        if (index >= 0 && index <= targets.Count)
                        {
                            if (power >= targets[index])
                            {
                                targets.RemoveAt(index);
                                break;
                            }
                            targets[index] -= power;
                            break;
                        }
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                            break;
                        }
                        break;
                    case "Add":
                        if (index >= 0 && index <= targets.Count)
                        {
                            targets.Insert(index, power);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                            break;
                        }
                    case "Strike":
                        int rightIndexToRemove = index + power;
                        int leftIndexToRemove = index - power;
                        if (leftIndexToRemove < 0 || rightIndexToRemove > targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            break;
                        }                     
                        for (int i = index; i <= rightIndexToRemove; i++)
                        {
                            if (index >= targets.Count)
                            {
                                Console.WriteLine("Strike missed!");
                                break;
                            }
                            targets.RemoveAt(index);
                        }
                        if (leftIndexToRemove < 0)
                        {
                            leftIndexToRemove = 0;
                        }
                        for (int i = leftIndexToRemove; i < index; i++)
                        {
                            if (leftIndexToRemove >= targets.Count)
                            {
                                Console.WriteLine("Strike missed!");
                                break;
                            }
                            targets.RemoveAt(leftIndexToRemove);
                        }                                                                                                              
                        break;
                    default:
                        break;
                }
                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }                                       
            Console.WriteLine(string.Join('|', targets));          
        
        }
    }
}
