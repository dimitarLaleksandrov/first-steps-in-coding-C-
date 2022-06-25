using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int sink = 40;
            const int oven = 50;
            const int countertop = 60;
            const int wall = 70;
            int sinkCounter = 1;
            int ovenCounter = 1;
            int countertopCounter = 1;
            int wallCounter = 1;
            int floor = 1;
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<string, int> locations = new Dictionary<string, int>();
            while (true)
            {
                var white = whiteTiles.Peek();
                var grey = greyTiles.Peek();
                if(white == grey)
                {
                    var sum = white + grey;
                    if (sum == sink)
                    {
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                        if (!locations.ContainsKey("Sink"))
                        {
                            locations.Add("Sink", sinkCounter);
                        }
                        else
                        {
                            locations["Sink"] += 1;
                        }
                        
                    }
                    else if (sum == oven)
                    {
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                        if (!locations.ContainsKey("Oven"))
                        {
                            locations.Add("Oven", ovenCounter);
                        } 
                        else
                        {
                            locations["Oven"] += 1;
                        }

                    }
                    else if (sum == countertop)
                    {
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                        if (!locations.ContainsKey("Countertop"))
                        {
                            locations.Add("Countertop", countertopCounter);
                        }
                        else
                        {
                            locations["Countertop"] += 1;
                        }
                    }
                    else if (sum == wall)
                    {
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                        if (!locations.ContainsKey("Wall"))
                        {
                            locations.Add("Wall", wallCounter);
                        }
                        else
                        {
                            locations["Wall"] += 1;
                        }
                    }
                    else
                    {
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                        if (!locations.ContainsKey("Floor"))
                        {
                            locations.Add("Floor", floor);
                        }
                        else
                        {
                            locations["Floor"] += 1; ;
                        }
                    }
                }
                else
                {
                    white = white / 2;
                    whiteTiles.Pop();
                    whiteTiles.Push(white);
                    greyTiles.Dequeue();
                    greyTiles.Enqueue(grey);
                }
                if (whiteTiles.Count == 0)
                {
                    break;
                }
                else if (greyTiles.Count == 0)
                {
                    break;
                }
                else if (whiteTiles.Count == 0 && greyTiles.Count == 0)
                {
                    break;
                }
            }
            if(whiteTiles.Count == 0)
            {
                Console.WriteLine($"White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }
            if(greyTiles.Count == 0)
            {
                Console.WriteLine($"Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }
            foreach (var item in locations.OrderByDescending(k => k.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
