using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0; 
            if (figure == "square")
            {
                double num = double.Parse(Console.ReadLine());
                area = num * num;
                Console.WriteLine(area);
            }
            else if(figure == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                area = num1 * num2;
                Console.WriteLine(area);
            }
            else if(figure == "circle")
            {
                double side = double.Parse(Console.ReadLine());
                area = Math.PI * (side * side);
                Console.WriteLine(area);
            }
            else if(figure == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (length * height) / 2;
                Console.WriteLine(area);

            }


        }
    }
}
