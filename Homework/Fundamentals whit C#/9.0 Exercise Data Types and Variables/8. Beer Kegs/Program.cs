using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            string theBigersKeg = string.Empty;
            double theBIgestVolumeOfKeg = 0;
            for (int i = 1; i <= numOfLines; i++)
            {
                string modelOfkeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());
                double volumeOfKeg = Math.PI * (radiusOfKeg * radiusOfKeg) * heightOfKeg;              
                if (volumeOfKeg < theBIgestVolumeOfKeg)
                {
                    theBIgestVolumeOfKeg = theBIgestVolumeOfKeg;
                    theBigersKeg = theBigersKeg;
                }
                else
                {
                    theBigersKeg = modelOfkeg;
                    theBIgestVolumeOfKeg = volumeOfKeg;
                }              
            }
            Console.WriteLine($"{theBigersKeg}");
        }
    }
}
