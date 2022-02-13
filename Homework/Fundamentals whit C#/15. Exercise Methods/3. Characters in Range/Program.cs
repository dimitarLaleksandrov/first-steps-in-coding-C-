using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char resolt = CharektersRange(first, second);
           

            
            
        }
        static char CharektersRange(char first, char second)
        {
            int firstChar = Convert.ToInt32(first);
            int secondChar = Convert.ToInt32(second);
            char charBitwin = ' ';
            if (firstChar < secondChar)
            {
                firstChar = secondChar;
                secondChar = firstChar;
                for (int i = firstChar; i <= secondChar; i++)
                {
                    charBitwin = (char)i;
                    Console.Write((charBitwin) + " ");
                }             
            }
            else
            {
                for (int i = firstChar; i <= secondChar; i++)
                {
                    charBitwin = (char)i;
                    Console.Write((charBitwin) + " ");
                }
            }
            return charBitwin;
           
        }
    }
}
