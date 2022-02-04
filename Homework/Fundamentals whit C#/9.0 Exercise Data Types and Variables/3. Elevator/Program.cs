using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfPeople = double.Parse(Console.ReadLine());
            double elevatorCapacity = double.Parse(Console.ReadLine());
            double courses = Math.Ceiling(numOfPeople / elevatorCapacity);
            Console.WriteLine(courses);
        }
    }
}
