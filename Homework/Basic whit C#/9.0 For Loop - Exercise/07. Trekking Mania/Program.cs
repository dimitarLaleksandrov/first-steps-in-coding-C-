using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsNum = int.Parse(Console.ReadLine());
            double groupAllSum = 0;
            double musala = 0;
            double monblan = 0;
            double kilimandgaro = 0;
            double kTwo = 0;
            double everest = 0;
            for (int i = 0; i < groupsNum; i++)
            {
                int peopleNum = int.Parse(Console.ReadLine());
                if (peopleNum <= 5)
                {
                    musala += peopleNum;
                }
                else if (peopleNum <= 12)
                {
                    monblan += peopleNum;
                }
                else if (peopleNum <= 25)
                {
                    kilimandgaro += peopleNum;
                }
                else if (peopleNum <= 40)
                {
                    kTwo += peopleNum;
                }
                else
                {
                    everest += peopleNum;
                }
                groupAllSum += peopleNum;
            }
            double musalaProcent = musala / groupAllSum * 100;
            double monblanProcent = monblan / groupAllSum * 100;
            double kilimandgaroProcent = kilimandgaro / groupAllSum * 100;
            double kTwoProcent = kTwo / groupAllSum * 100;
            double everestProcent = everest / groupAllSum * 100;
            Console.WriteLine($"{musalaProcent:f2}%");
            Console.WriteLine($"{monblanProcent:f2}%");
            Console.WriteLine($"{kilimandgaroProcent:f2}%");
            Console.WriteLine($"{kTwoProcent:f2}%");
            Console.WriteLine($"{everestProcent:f2}%");
        }
    }
}
