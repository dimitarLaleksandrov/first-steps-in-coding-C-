using System;

namespace array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [20];
            array[0] = 10;
            array[1] = 1;
            array[2] = 2;
            array[3] = 10;
            array[4] = 4;
            array[5] = 7;
            array[6] = 8;
            array[7] = 11;
            array[8] = 14;
            array[9] = 17;
            array[10] = 15;
            array[11] = 17;
            array[12] = 19;
            array[13] = 9;
            array[14] = 6;
            array[15] = 5;
            array[16] = 3;
            array[17] = 18;
            array[18] = 12;
            array[19] = 13;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 5;
                Console.WriteLine(array[i]);                               
            }
        }
    }
}
