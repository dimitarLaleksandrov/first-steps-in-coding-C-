using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePad = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\text.txt";
            string output = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\output.txt";
            ProccesLine(filePad, output);
        }
        static void ProccesLine (string filePad, string output)
        {
            string[] lines = File.ReadAllLines(filePad);
            int count = 0;
            List<string> outputLInes = new List<string>();
            foreach (var line in lines)
            {
                count++;
                int countLetters = line.Count(char.IsLetter);
                int simbolCounter = line.Count(char.IsPunctuation);
                string newLine = $"Line {count}: {line} ({countLetters})({simbolCounter})";
                outputLInes.Add(newLine);
            }
            File.WriteAllLines(output, outputLInes);
        }
    }
}
