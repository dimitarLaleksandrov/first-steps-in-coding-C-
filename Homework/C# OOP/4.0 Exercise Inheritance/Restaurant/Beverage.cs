using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        private string name;
        private decimal price;
        private double milliliters;

        public Beverage(string name, decimal price, double mililliters) : base(name, price)
        {
            Milliliters = mililliters;
        }
        public double Milliliters
        {
            get { return milliliters; }
            set { milliliters = value; }
        }
    }
}
