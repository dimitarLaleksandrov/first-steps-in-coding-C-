using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studenttName = Console.ReadLine();
            //string studenttName = Console.ReadLine();
            int studenttAge = int.Parse(Console.ReadLine());
            double studentGrade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studenttName}, Age: {studenttAge}, Grade: {studentGrade:f2}");
        }
    }
}
