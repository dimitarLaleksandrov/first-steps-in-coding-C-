using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int gladius = 70;
            const int shamshir = 80;
            const int katana = 90;
            const int sabre = 110;
            const int broadsword = 150;
            Queue<int> steals = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> carbons = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            SortedDictionary<string, int> swards = new SortedDictionary<string, int>();
            int swardCounter = 0;
            while (steals.Count > 0 && carbons.Count > 0)
            {
                int steal = steals.Dequeue();
                int carbon = carbons.Pop();
                int sum = steal + carbon;
                if(sum == gladius)
                {
                    if (swards.ContainsKey("Gladius"))
                    {
                        swards["Gladius"] += 1;
                        swardCounter++;
                    }
                    else
                    {
                        swards.Add("Gladius", 1);
                        swardCounter++;
                    }
                   
                }
                else if(sum == shamshir)
                {
                    if (swards.ContainsKey("Shamshir"))
                    {
                        swards["Shamshir"] += 1;
                        swardCounter++;
                    }
                    else
                    {
                        swards.Add("Shamshir", 1);
                        swardCounter++;
                    }
                }
                else if (sum == katana)
                {
                    if (swards.ContainsKey("Katana"))
                    {
                        swards["Katana"] += 1;
                        swardCounter++;
                    }
                    else
                    {
                        swards.Add("Katana", 1);
                        swardCounter++;
                    }
                }
                else if (sum == sabre)
                {
                    if (swards.ContainsKey("Sabre"))
                    {
                        swards["Sabre"] += 1;
                        swardCounter++;
                    }
                    else
                    {
                        swards.Add("Sabre", 1);
                        swardCounter++;
                    }
                }
                else if (sum == broadsword)
                {
                    if (swards.ContainsKey("Broadsword"))
                    {
                        swards["Broadsword"] += 1;
                        swardCounter++;
                    }
                    else
                    {
                        swards.Add("Broadsword", 1);
                        swardCounter++;
                    }
                }
                else
                {
                    carbons.Push(carbon + 5);
                }
            }
            if(swardCounter == 0)
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            }
            else
            {
                Console.WriteLine($"You have forged {swardCounter} swords.");
            }
            if(steals.Count == 0)
            {
                Console.WriteLine($"Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steals)}");
                
            }
            if(carbons.Count == 0)
            {
                Console.WriteLine($"Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbons)}");
            }
            if(swards.Count > 0)
            {
                foreach (var sward in swards)
                {
                    Console.WriteLine($"{sward.Key}: {sward.Value}");
                }
            }
        }
    }
}
