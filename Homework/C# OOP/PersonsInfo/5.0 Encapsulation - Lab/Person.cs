﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private decimal salary;
        public Person(string firstname, string lastname, int age, decimal salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Salary = salary;
        }
        public string FirstName
        {
            get { return firstname; }
            private set {
                            if(value.Length < 3)
                            {
                                 throw new ArgumentException($"First name cannot contain fewer than 3 symbols!");
                            }
                            firstname = value;
                        }
        }
        public string LastName
        {
            get { return lastname; }
            private set {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Last name cannot contain fewer than 3 symbols!");
                }
                lastname = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set { 
                if(value <= 0)
                {
                    throw new ArgumentException($"Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            private set { 
                if(value < 650)
                {
                    throw new ArgumentException($"Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
