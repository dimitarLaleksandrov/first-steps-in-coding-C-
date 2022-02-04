using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0;
            int classFails = 0;
            int clas = 1;
            while (clas <= 12)
            {
                double evaluation = double.Parse(Console.ReadLine());
                if (evaluation < 4.00)
                {
                    classFails++;
                    if (classFails == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas} grade");
                        break;
                    }
                    continue;
                }
                grade += evaluation;
                clas++;
            }
            double avegeClass = grade / 12;
            if (clas > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avegeClass:f2}");
            }
        }
    }
}
