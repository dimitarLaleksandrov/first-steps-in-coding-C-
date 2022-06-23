using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Classroom_Skeleton
{
    public class Classroom
    {
        public Classroom(int capacity)
        {
            Capacity = capacity;
            Students = new List<Student>(capacity);
        }
        private List<Student> students;
        private int capacity;
        private int count;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        public string RegisterStudent(Student student)
        {
            if(Capacity > 0)
            {
                Students.Add(student);
                Capacity--;
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            var student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (student != null)
            {
                Students.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }
            return $"Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            var st = Students.Where(s => s.Subject == subject);
            var text = new StringBuilder();
            if (st.Count() > 0)
            {
                text.AppendLine($"Subject: {subject}");
                text.AppendLine($"Students:");
                foreach (var s in st)
                {
                    text.AppendLine($"{s.FirstName} {s.LastName}");
                }
                return text.ToString();
            }
            return $"No students enrolled for the subject";
        }
        public int GetStudentsCount()
        {
            return students.Count();
        }
        public string GetStudent(string firstName, string lastName)
        {
            foreach (var st in Students)
            {
                if(st.FirstName == firstName && st.LastName == lastName)
                {
                    return $"Student: First Name = {st.FirstName}, Last Name = {st.LastName}, Subject = {st.Subject}";
                }
            }
            return $"Student not found";
        }
    }
}
