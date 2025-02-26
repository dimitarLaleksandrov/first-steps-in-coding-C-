﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Town
        {
            get { return town; }
            set
            {
                town = value;
            }
        }

        public int CompareTo([AllowNull] Person other)
        {
            int result = Name.CompareTo(other.Name);
            if(result == 0)
            {
                result = Age.CompareTo(other.Age);
            }
            if (result == 0)
            {
                result = Town.CompareTo(other.Town);
            }
            return result;
        }
    }
}
