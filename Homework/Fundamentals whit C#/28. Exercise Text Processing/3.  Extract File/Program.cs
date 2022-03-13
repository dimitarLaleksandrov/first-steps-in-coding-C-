using System;
using System.Linq;

namespace _3.__Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            int fileNameStartIndex = filePath.LastIndexOf('\\') + 1;
            int dotIndex = filePath.LastIndexOf('.');
            string fileName = filePath.Substring(fileNameStartIndex, dotIndex - fileNameStartIndex);
            string extentsion = filePath.Substring(dotIndex + 1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extentsion}");


            //string[] fileInfo = Console.ReadLine().Split('\\').Last().Split('.').ToArray();
            //string fileName = string.Join(".", fileInfo.Take(fileInfo.Length - 1));
            //string fileExtentsion = fileInfo.Last();
            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {fileExtentsion}");
        }
    }
}
