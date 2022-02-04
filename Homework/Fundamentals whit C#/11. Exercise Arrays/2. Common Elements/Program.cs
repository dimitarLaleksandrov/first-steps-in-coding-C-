using System;
using System.Linq;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] furstLine = Console.ReadLine().Split().ToArray();
            string[] secondLine = Console.ReadLine().Split().ToArray();
            string commonArrays = String.Empty;
            for (int i = 0; i < secondLine.Length; i++)
            {
                for (int j = 0; j < furstLine.Length; j++)
                {
                    if (secondLine[i] == furstLine[j])
                    {
                        commonArrays += secondLine[i] + " ";
                    }
                }
            }
            Console.WriteLine(commonArrays);
        }
    }
}
