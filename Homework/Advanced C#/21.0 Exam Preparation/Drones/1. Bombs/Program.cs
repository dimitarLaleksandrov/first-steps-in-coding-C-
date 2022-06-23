using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int daturaBombsValue = 40;
            const int cherryBombsValue = 60;
            const int smokeDecoyBombsValue = 120;
            Queue<int> effectsBomb = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> casingBomb = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;
            while (effectsBomb.Count > 0 && casingBomb.Count > 0)
            {
                if (daturaBombs >= 3  && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    break;
                }
                var effectsValue = effectsBomb.Peek();
                var casingValue = casingBomb.Peek();
                var sum = effectsValue + casingValue;
                if (sum == daturaBombsValue)
                {
                    effectsBomb.Dequeue();
                    casingBomb.Pop();
                    daturaBombs++;
                }
                else if (sum == cherryBombsValue)
                {
                    effectsBomb.Dequeue();
                    casingBomb.Pop();
                    cherryBombs++;
                }
                else if (sum == smokeDecoyBombsValue)
                {
                    effectsBomb.Dequeue();
                    casingBomb.Pop();
                    smokeDecoyBombs++;
                }
                else
                {
                    var bombsSum = effectsValue + casingValue;
                    while (true)
                    {
                        bombsSum -= 5;
                        if (bombsSum == daturaBombsValue)
                        {
                            effectsBomb.Dequeue();
                            casingBomb.Pop();
                            daturaBombs++;
                            break;
                        }
                        else if (bombsSum == cherryBombsValue)
                        {
                            effectsBomb.Dequeue();
                            casingBomb.Pop();
                            cherryBombs++;
                            break;
                        }
                        else if (bombsSum == smokeDecoyBombsValue)
                        {
                            effectsBomb.Dequeue();
                            casingBomb.Pop();
                            smokeDecoyBombs++;
                            break;
                        }
                    }
                }
            }
            if (daturaBombs > 2 && cherryBombs > 2 && smokeDecoyBombs > 2)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }
            if (effectsBomb.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effectsBomb)}");
            }
            if (casingBomb.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casingBomb)}");
            }
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
