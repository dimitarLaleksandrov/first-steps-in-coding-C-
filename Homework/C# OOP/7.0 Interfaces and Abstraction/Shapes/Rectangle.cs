using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
            
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public void Draw()
        {
            this.DrowLine(this.width, end: '*', mid: '*');
            for (int i = 1; i < this.height - 1; i++)
            {
                DrowLine(this.width, '*', ' ');
            }
            DrowLine(this.width, '*', '*');
        }

        private void DrowLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}