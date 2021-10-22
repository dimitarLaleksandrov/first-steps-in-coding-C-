using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;
            double sumOfAllGrades = 0;
            while (input != "Finish")
            {
                double sumGrades = 0;
                for (int i = 1; i <= jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                    counter++;
                    sumOfAllGrades += grade;
                }
                double avaeregeRating = sumGrades / jury;
                Console.WriteLine($"{input} - {avaeregeRating:f2}.");
                input = Console.ReadLine();
            }
            if (input == "Finish")
            {
                double allGrades = sumOfAllGrades / counter;
                Console.WriteLine($"Student's final assessment is {allGrades:f2}.");
            }         
        }
    }
}
