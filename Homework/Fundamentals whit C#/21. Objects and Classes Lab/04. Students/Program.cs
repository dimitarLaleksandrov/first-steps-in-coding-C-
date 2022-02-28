using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
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
                if (IsStudenExisting(students, firstname, lastName))
                {
                    Student student = GetStudent(students, firstname, lastName);
                    student.FirstName = firstname;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = cityOfStudant;
                    students.Add(student);
                }
                else
                {
                    Student student = new Student();
                    {
                        student.FirstName = firstname;
                        student.LastName = lastName;
                        student.Age = age;
                        student.HomeTown = cityOfStudant;
                    }
                    students.Add(student);
                }
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
            //List<Student> filtaredStudans = students.FindAll(x => x.HomeTown == city);
            //foreach (Student student in filtaredStudans)
            //{

            //}
        }
        static bool IsStudenExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student studen in students)
            {
                if (studen.FirstName == firstName && studen.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> students, string firstNmae, string lastName)
        {
            Student existingStudent = null;
            foreach  (Student student in students)
            {
                if (student.FirstName == firstNmae && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }
}
