using System;
using System.Text;

namespace _5._Digits__Letters__and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder lether = new StringBuilder();
            StringBuilder otherCharekters = new StringBuilder();
            string text = Console.ReadLine();
            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    lether.Append(ch);
                }
                else if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else
                {
                    otherCharekters.Append(ch);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(lether);
            Console.WriteLine(otherCharekters);
        }
    }
}
