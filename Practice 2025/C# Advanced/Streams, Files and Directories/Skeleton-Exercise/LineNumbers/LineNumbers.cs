namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (var text = new StreamReader(inputFilePath))
            {
                int counter = 1;
                string line = text.ReadLine();
                List<string> outPringString = new List<string>();

                while (line != null)
                {
                    int countLetters = line.Count(char.IsLetter);
                    int symbols = line.Count(char.IsPunctuation);
                    Console.WriteLine($"Line {counter}: {line} ({countLetters})({symbols})");
                    string newString = $"Line {counter}: {line} ({countLetters})({symbols})";
                    outPringString.Add(newString);
                    counter++;
                    line = text.ReadLine();
                }
                File.WriteAllLines(outputFilePath, outPringString);
            }
        }
    }
}
