﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
           this.Name = name;
           this.Cost = cost;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be an empty string");
                }
                this.name = value;
            }
        }
        public decimal Cost
        {
            get { return cost; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException(" Money cannot be a negative number");
                }
                this.cost = value;
            }
        }
    }
}
