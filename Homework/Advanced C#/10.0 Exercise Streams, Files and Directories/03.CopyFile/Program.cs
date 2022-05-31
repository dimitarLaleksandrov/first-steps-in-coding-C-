using System;
using System.IO;
using System.IO.Enumeration;

namespace _03.CopyFile
{
    internal class CopyFile
    {
        static void Main(string[] args)
        {
            string filePad = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\text.txt";
            string output = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\output-copy.txt";
            CoppyFile(filePad, output);
        }
        public static void CoppyFile (string filePad, string output)
        {
            using (FileStream reader = new FileStream(filePad, FileMode.Open))
            {
                using (FileStream writer = new FileStream(output, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int biteCounter = reader.Read(buffer, 0, buffer.Length);
                        if (biteCounter == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, biteCounter);
                    }
                }
            }
        }
    }
}
