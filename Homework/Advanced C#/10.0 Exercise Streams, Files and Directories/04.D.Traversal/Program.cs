using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.D.Traversal
{
    internal class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string reportFileName = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\report.txt";

            var reportContent =  TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static Dictionary<string, List<FileInfo>> TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, List<FileInfo>> extencionInfo = new Dictionary<string, List<FileInfo>>();

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                var extencion = fileInfo.Extension;
                if (!extencionInfo.ContainsKey(extencion))
                {
                    extencionInfo.Add(extencion, new List<FileInfo>());
                }
                extencionInfo[extencion].Add(fileInfo);
            }
            foreach (var extencion in extencionInfo.OrderByDescending(entry => entry.Value.Count).ThenBy(entry => entry.Key))
            {
                string extencions = extencion.Key;
                List<FileInfo> file = extencion.Value;
                file.OrderByDescending(file => file.Length);
                foreach (var fileInfo in file)
                {
                    Console.WriteLine($"--{fileInfo.Name} - {fileInfo.Length / 1024:f3}kb");
                }
            } 
            return extencionInfo;
        }

        public static void WriteReportToDesktop(Dictionary<string, List<FileInfo>> textContent, string reportFileName)
        {
            string patReport = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(patReport, textContent.Keys.First());

        }
    }
}
