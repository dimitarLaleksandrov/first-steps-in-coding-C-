using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int workersConsumes = 26;
            const int yieldDrop = 10;
            uint stratingYield = uint.Parse(Console.ReadLine());
            uint extraktedYield = 0;
            uint yield = stratingYield;
            int days = 0;
            uint totalYield = 0;
            while (yield >= 100)
            {
                extraktedYield = stratingYield - workersConsumes;
                totalYield += extraktedYield;
                yield -= yieldDrop;
                stratingYield = yield;
                days += 1;
                if (totalYield < workersConsumes)
                {
                    totalYield = totalYield;
                }
                Console.WriteLine(totalYield);
            }          
            totalYield -= workersConsumes;
            Console.WriteLine(days);
            Console.WriteLine(totalYield);
        }
    }
}
