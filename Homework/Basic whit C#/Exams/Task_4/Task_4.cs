using System;

namespace Task_4
{
    class Task_4
    {
        static void Main(string[] args)
        {
            int studentNum = int.Parse(Console.ReadLine());
            double lowerThenThree = 0;
            double lowerThenFour = 0;
            double lowerThenFive = 0;
            double upThenFive = 0;
            double totalScore = 0;
            for (int i = 0; i < studentNum; i++)
            {
                double score = double.Parse(Console.ReadLine());
                if (score < 3)
                {
                    lowerThenThree++;
                }
                else if (score < 4)
                {
                    lowerThenFour++;
                }
                else if (score < 5)
                {
                    lowerThenFive++;
                }
                else
                {
                    upThenFive++;
                }
                totalScore += score;
            }
            double studentProcentLowerThenThree = (lowerThenThree / studentNum) * 100;
            double studentProcentLowerThenFour = (lowerThenFour / studentNum) * 100;
            double studentProcentLowerThenFive = (lowerThenFive / studentNum) * 100;
            double studentProcentUpThenFive = (upThenFive / studentNum) * 100;
            double average = totalScore / studentNum;
            Console.WriteLine($"Top students: {studentProcentUpThenFive:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {studentProcentLowerThenFive:f2}% ");
            Console.WriteLine($"Between 3.00 and 3.99: {studentProcentLowerThenFour:f2}%");
            Console.WriteLine($"Fail: {studentProcentLowerThenThree:f2}% ");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
