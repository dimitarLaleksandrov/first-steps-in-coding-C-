using System;

namespace array_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[n];
            int furstNum = 0;
            for (int i = 0; i < n; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
                furstNum = arrayOne[i];
                if (i != 0)
                {
                    
                    if (arrayOne[i] < arrayOne[i - 1])
                    {
                        furstNum = arrayOne[i];
                    }
                    if (arrayOne[i] > arrayOne[i - 1])
                    {
                        furstNum = arrayOne[i - 1];
                    }
                    
                }
                Console.WriteLine(furstNum);

            }
            

        }
    }
}
