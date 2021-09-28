using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            if(day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                Console.WriteLine(12);
            }
            if(day == "Wednesday" || day == "Thursday")
            {
                Console.WriteLine(14);
            }
            if(day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine(16);
            }
        }
    }
}
