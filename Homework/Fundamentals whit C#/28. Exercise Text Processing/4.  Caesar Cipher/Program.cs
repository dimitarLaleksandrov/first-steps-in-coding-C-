using System;
using System.Linq;

namespace _4.__Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray().Select(cha => Convert.ToChar(cha + 3)).ToArray();
            Console.WriteLine(input);
        }
    }
}
