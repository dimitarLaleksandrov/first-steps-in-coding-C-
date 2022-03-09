using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double gradeToHit = 4.50;
            int numOfRows = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 1; i <= numOfRows; i++)
            {
                string name = Console.ReadLine();
                double grade= double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
               students[name].Add(grade);
            }
            foreach (var kvp in students.Where(kvp => kvp.Value.Average() >= gradeToHit))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
