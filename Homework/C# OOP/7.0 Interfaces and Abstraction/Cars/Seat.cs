using System.Text;

namespace Cars
{
    public class Seat : Car
    {
        public Seat(string model, string color) : base(model, color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
               .AppendLine(base.ToString())
               .AppendLine(this.Start())
               .AppendLine(this.Stop());
            return sb.ToString().TrimEnd();
        }     
    }
}