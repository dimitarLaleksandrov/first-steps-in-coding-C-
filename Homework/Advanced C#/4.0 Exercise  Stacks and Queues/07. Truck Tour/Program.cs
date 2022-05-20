using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                int[] station = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int current = station[0] - station[1];
                q.Enqueue(current);
            }
            if (q.Sum() < 0)
            {
                return;
            }
            for (int j = 0; j < n; j++)
            {
                bool hasNotFailet = true;
                long totalFuel = 0;
                foreach (int item in q)
                {
                    totalFuel += item;
                    if(totalFuel < 0)
                    {
                        hasNotFailet = false;
                        break;
                    }
                }
                if (hasNotFailet)
                {
                    Console.WriteLine(j);
                    break;
                }
                else
                {
                    q.Enqueue(q.Dequeue());
                }
            }
            //int NumOfTours = int.Parse(Console.ReadLine());
            //Queue<Pump> pumpQueues = new Queue<Pump>();
            //for (int i = 1; i <= NumOfTours; i++)
            //{
            //    string data = Console.ReadLine();
            //    int amaunt = int.Parse(data.Split()[0]);
            //    int distance = int.Parse(data.Split()[1]);
            //    Pump pump = new Pump(i, amaunt, distance);
            //    pumpQueues.Enqueue(pump);
            //}
            //int totalDistance = pumpQueues.Sum(pump => pump.Distance);
            //int trukDistanc = 0;
           
            //while (true)
            //{
            //    int trukFuel = 0;
            //    foreach (Pump pupm in pumpQueues)
            //    {

            //    }

            //}
        }
    }
}
