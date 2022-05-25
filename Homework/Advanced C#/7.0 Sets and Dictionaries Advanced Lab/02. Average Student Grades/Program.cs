using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 1; i <= n; i++)
            {
                string[] studentGrade = Console.ReadLine().Split(" ");
                if (!students.ContainsKey(studentGrade[0]))
                {
                    students.Add(studentGrade[0], new List<decimal>());
                    students[studentGrade[0]].Add(decimal.Parse(studentGrade[1]));
                }
                else
                {
                    students[studentGrade[0]].Add(decimal.Parse(studentGrade[1]));
                }
            }
            foreach (var student in students)
            {
                decimal avgGrades = student.Value.Average();
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value):f2} (avg: {avgGrades:f2})");
            }
        }
    }
}
