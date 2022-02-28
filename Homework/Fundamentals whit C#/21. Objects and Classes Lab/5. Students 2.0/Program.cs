using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Students_2._0
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Student> students = new List<Student>();
            while (info[0] != "end")
            {
                string firstname = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string cityOfStudant = info[3];
                Student student = new Student();
                {
                    student.FirstName = firstname;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = cityOfStudant;
                }
                students.Add(student);
                info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
