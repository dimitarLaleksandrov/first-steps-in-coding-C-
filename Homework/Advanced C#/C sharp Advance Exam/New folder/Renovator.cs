﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;
        }
        private string name;
        private string type;
        private double rate;
        private int days;
        private bool hired;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public int Days
        {
            get { return days; }
            set
            {
                days = value;
            }
        }
        public bool Hired
        {
            get { return hired = false; }
            set
            {
                hired = value;
            }
        }
        public override string ToString()
        {
            return $"-Renovator: {Name}" + Environment.NewLine +
                   $"--Specialty: {Type}" + Environment.NewLine +
                   $"--Rate per day: {Rate} BGN";
        }
    }
}
