using System;
using System.IO;
using System.Runtime.Serialization;

namespace _02._Line_Numbers
{
    internal class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader(@"input.txt");
            using (input)
            {
                var writer = new StreamWriter(@"output.txt");
                using (writer)
                {
                    int lineNum = 1;
                    while (true)
                    {
                        string line = input.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        writer.WriteLine($"{lineNum}. {line}");
                        lineNum++;
                    }
                }
            }
        }
    }
}
