using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
           this.Length = length;
           this.Width = width;
           this.Height = height;
        }

        public double Length 
        { 
            get { return this.length; }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public double SurfaceArea()
        {
            double area = (2 * (this.Length * this.Width)) + (2 * (this.Length * this.Height)) + (2 * (this.Width * this.Height));
            return area;
        }
        public double LateralSurfaceArea()
        {
            double laterArea = (2 * (this.Length * this.Height)) + (2 * (this.Width * this.Height));
            return laterArea;
        }
        public double Volume()
        {
            double valume = this.Length * this.Width * this.Height;
            return valume;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Surface Area - {this.SurfaceArea():f2}")
                .AppendLine($"SLateral Surface Area - {this.LateralSurfaceArea():f2}")
                .AppendLine($"Volume - {this.Volume():f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
