using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    public class Student
    {
        public Student(string firstName, string lastName, double grade) // argument of teh class
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            // property = argument
        }

        public string FirstName { get; set; } // property
        public string LastName { get; set; }
        public double Grade { get; set; }
        // filds -> inporten  = private  "const"
        // construktors -> inportend     const - tab - tab
        //properties -> inport = public  get = accessors  "read"  set = mutators =  chainging "write"
        //methods (behaviour) -> inport
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           int numOfStudants = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 1; i <= numOfStudants; i++)
            {
                string[] studentArgument = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string curentStudentFirstName = studentArgument[0];
                string curentStudentLastName = studentArgument[1];
                double curentStudentGrade = double.Parse(studentArgument[2]);
                Student curentStudent =  new Student(curentStudentFirstName, curentStudentLastName, curentStudentGrade);
                students.Add(curentStudent);
            }
            List<Student> orderedStudent = students.OrderByDescending(student => student.Grade).ToList();
            // students = students.orderByDescending(student => student.Grade).ToList();
            foreach (Student student in orderedStudent)
            {
                Console.WriteLine(student);
            }
        }
    }
}
