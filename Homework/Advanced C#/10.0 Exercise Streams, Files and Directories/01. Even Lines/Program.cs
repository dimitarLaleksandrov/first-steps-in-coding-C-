using System;
using System.IO;
using System.Linq;

namespace _01._Even_Lines
{
    internal class EvenLines
    {
        static void Main(string[] args)
        {
            string filePad = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\text.txt";
            using (StreamReader reader = new StreamReader(filePad))
            {
                int counter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = Replace(line);
                    line = Reverce(line);
                    if (counter % 2  == 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
        private static string Replace (string line)
        {
            return line.Replace("-", "@").Replace(",", "@").Replace(".", "@").Replace("!", "@").Replace("?", "@");
        }
        private static string Reverce (string line)
        {
            return string.Join(" ", line.Split().Reverse());
        }
    }
}
