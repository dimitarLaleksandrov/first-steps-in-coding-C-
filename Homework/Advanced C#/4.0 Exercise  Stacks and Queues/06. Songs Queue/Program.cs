using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queueSongs = new Queue<string>(songs);
            while (queueSongs.Count > 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    if (queueSongs.Count > 0)
                    {
                        queueSongs.Dequeue();
                    }
                }
                else if (command.Contains("Add"))
                {
                    string songTOAdd = command.Split("Add ")[1];
                    if (queueSongs.Contains(songTOAdd))
                    {
                        Console.WriteLine($"{songTOAdd} is already contained!");
                    }
                    else
                    {
                        queueSongs.Enqueue(songTOAdd);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueSongs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
