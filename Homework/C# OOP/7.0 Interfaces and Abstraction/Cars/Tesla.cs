using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : Car, IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Batteries { get; private set; }

        public Tesla(string model, string color, int batteries) : base(model, color)
        {
            this.Model = model;
            this.Color = color;
            this.Batteries = batteries;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
               .AppendLine($"{base.ToString()} with {this.Batteries} batteries")
               .AppendLine(this.Start())
               .AppendLine(this.Stop());
            return sb.ToString().TrimEnd();
        }   
    }
}
