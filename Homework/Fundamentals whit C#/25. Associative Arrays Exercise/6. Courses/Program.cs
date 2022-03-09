using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (input[0] != "end")
            {
                string courseName = input[0];
                string studentName = input[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
                input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
