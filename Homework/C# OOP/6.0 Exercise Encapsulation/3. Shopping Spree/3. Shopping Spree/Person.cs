using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private readonly List<Product> bag;

        public Person(string name, decimal money)
        {
           this.Name = name;
           this.Money = money;
           this.bag = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name cannot be an empty string");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get { return money; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be a negative number");
                }
                this.money = value;
            }
        }
        public List<Product> Bag
        {
            get { return bag; }
        }
    }
}
