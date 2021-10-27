using System;

namespace Rhythmic_gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxPoints = 20;
            string contry = Console.ReadLine();
            string instrument = Console.ReadLine();
            double performance = 0;
            double difikalt = 0;
            switch (contry)
            {
                case "Russia":
                    switch (instrument)
                    {
                        case "ribbon":
                            difikalt = 9.100;
                            performance = 9.400;
                            break;
                        case "hoop":
                            difikalt = 9.300;
                            performance = 9.800;
                            break;
                        case "rope":
                            difikalt = 9.600;
                            performance = 9.000;
                            break;
                        default:
                            break;
                    }
                    break;            
                case "Bulgaria":
                    switch (instrument)
                    {
                        case "ribbon":
                            difikalt = 9.600;
                            performance = 9.400;
                            break;
                        case "hoop":
                            difikalt = 9.550;
                            performance = 9.750;
                            break;
                        case "rope":
                            difikalt = 9.500;
                            performance = 9.400;
                            break;
                        default:
                            break;
                    }
                    break;               
                case "Italy":
                    switch (instrument)
                    {
                        case "ribbon":
                            difikalt = 9.200;
                            performance = 9.500;
                            break;
                        case "hoop":
                            difikalt = 9.450;
                            performance = 9.350;
                            break;
                        case "rope":
                            difikalt = 9.700;
                            performance = 9.150;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            double allPoints = difikalt + performance;
            double pointLeft = maxPoints - allPoints;
            double procentNeed = pointLeft / maxPoints * 100;
            Console.WriteLine($"The team of {contry} get {allPoints:f3} on {instrument}.");
            Console.WriteLine($"{procentNeed:f2}%");
        }
    }
}
