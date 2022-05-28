using System;
using System.IO;

namespace _01._Odd_Lines
{
    internal class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader inputPatternFile = new StreamReader("input.txt");
            using (inputPatternFile)
            {
                var writer = new StreamWriter("output.txt");
                using (writer)
                {
                    int lineNum = 0;
                    while (true)
                    {
                        string line = inputPatternFile.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (lineNum % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        lineNum++;
                    }
                }
            }
        }
    }
}
