using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private string name;
        private int age;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual int Age
        { 
            get { return age; }
            set 
            { 
                if(value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
