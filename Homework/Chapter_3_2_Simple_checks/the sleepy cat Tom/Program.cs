using System;

namespace the_sleepy_cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int hostAtWork = (365 - restDays) * 63;
            int hostInRests = restDays * 127;
            var totalPlayMinuts = hostAtWork + hostInRests;
            var difarent = Math.Abs(totalPlayMinuts - 30000);
            var hours = difarent / 60;
            var min = difarent % 60;
            if(totalPlayMinuts > 30000)
            {
                Console.WriteLine("Tom will run away!");
                Console.WriteLine($"{hours} hours {min} minutes more to play!");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {min} minutes less for play");
            }
        }
    }
}
