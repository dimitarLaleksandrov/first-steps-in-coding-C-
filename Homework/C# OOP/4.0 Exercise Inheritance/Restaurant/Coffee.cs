﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee :HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50m;
        private double caffeine;
        public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
        public double Caffeine
        {
            get { return caffeine; }
            set { caffeine = value; }
        }
    }
}
