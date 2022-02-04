using System;

namespace Exam_One
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthShip = double.Parse(Console.ReadLine());
            double lengthShip = double.Parse(Console.ReadLine());
            double heightShip = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());
            double rocketVolume = widthShip * lengthShip * heightShip;
            double roomSpace = (averageHeight + 0.40) * 2 * 2;
            double allPersons = Math.Floor(rocketVolume / roomSpace);
            if (allPersons >=3 && allPersons <= 10)
            {
                Console.WriteLine($"The spacecraft holds {allPersons} astronauts.");
            }
            else if (allPersons < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (allPersons > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
