using System;
using System.Collections.Generic;
namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            List<string> result = FindSymbolsBetweenChars(firstSymbol, secondSymbol);
            foreach (var currentSymbol in result)
            {
                Console.Write(currentSymbol + " ");
            }
        }

        private static List<string> FindSymbolsBetweenChars(char firstSymbol, char secondSymbol)
        {
            List<string> charSymbols = new List<string>();

            int firstCharNumber = Convert.ToInt32(firstSymbol);
            int secondCharNumber = Convert.ToInt32(secondSymbol);

            if (firstCharNumber < secondSymbol)
            {
                for (int i = firstSymbol + 1; i < secondSymbol; i++)
                {
                    char currentChar = (char)i;
                    string charr = currentChar.ToString();
                    charSymbols.Add(charr);
                }
            }
            else if (secondSymbol < firstSymbol)
            {
                for (int i = secondSymbol + 1; i < firstSymbol; i++)
                {
                    char currentChar = (char)i;
                    string charr = currentChar.ToString();
                    charSymbols.Add(charr);
                }
            }
            return charSymbols;
        }
    }
}
