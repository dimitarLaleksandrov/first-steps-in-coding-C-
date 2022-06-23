using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }
        private string manufacturer;
        private string model;
        private int year;
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
            }
        }
        public override string ToString()
        {
            return $"{Manufacturer} {Model} {Year}";
        }
    }
}
