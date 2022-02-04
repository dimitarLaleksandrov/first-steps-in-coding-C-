using System;

namespace projectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArchitect = (Console.ReadLine());
            int projects = int.Parse(Console.ReadLine());
            var hours = projects * 3;
            Console.WriteLine($"The architect {nameOfTheArchitect} will need {hours} hours to complete {projects} project/s.");

        }
    }
}
