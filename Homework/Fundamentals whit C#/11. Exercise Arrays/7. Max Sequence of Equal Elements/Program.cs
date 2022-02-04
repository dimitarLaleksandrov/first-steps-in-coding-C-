using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int longestLength = 1;
            int curentNum = 1;
            int longestNum = 0;
            int curentLongestNum = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    curentNum++;
                    if (curentNum > longestLength)
                    {
                        longestLength = curentNum;
                        longestNum = curentLongestNum;
                    }
                }
                else
                {
                    curentNum = 1;
                    curentLongestNum = i;
                }             
            }
            for (int i = longestNum; i < longestNum + longestLength ; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
