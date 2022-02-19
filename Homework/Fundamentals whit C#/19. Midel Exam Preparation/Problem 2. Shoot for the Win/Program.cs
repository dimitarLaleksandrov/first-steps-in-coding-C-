using System;
using System.Linq;

namespace Problem_2._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int shootCounter = 0;
            while (command != "End")
            {
                int indexToShoot = int.Parse(command);
                if (indexToShoot >= 0 && indexToShoot < targets.Length && targets[indexToShoot] != -1)
                {
                    var valueOfTarget = targets[indexToShoot];
                    if (valueOfTarget != -1)
                    {
                        targets[indexToShoot] = -1;
                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] == -1)
                            {
                                continue;
                            }
                            if (targets[i] > valueOfTarget)
                            {
                                targets[i] -= valueOfTarget;
                            }
                            else
                            {
                                targets[i] += valueOfTarget;
                            }
                        }
                        shootCounter++;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shootCounter} -> {string.Join(" ", targets)}");
        }
        static void ShutTarget(int indexToShoot, int[] targets)
        {
            var valueOfTarget = targets[indexToShoot];
            if (valueOfTarget != -1)
            {
                targets[indexToShoot] = -1;
                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    if (targets[i] > valueOfTarget)
                    {
                        targets[i] -= valueOfTarget;
                    }
                    else
                    {
                        targets[i] += valueOfTarget;
                    }
                }
            }
        }
    }
}
