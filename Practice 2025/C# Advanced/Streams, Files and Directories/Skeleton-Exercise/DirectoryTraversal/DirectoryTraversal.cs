namespace DirectoryTraversal
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, List<FileInfo>> extInfo = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files) 
            {
                FileInfo fileInfo = new FileInfo(file);
                var ext = fileInfo.Extension;
                if (extInfo.ContainsKey(ext))
                {
                    extInfo.Add(ext, new List<FileInfo>());
                }
                extInfo[ext].Add(fileInfo);
            }
            extInfo.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key);

            foreach (var file in extInfo) 
            {
                var ext = file.Key;
                List<FileInfo> filesInfo = file.Value;
                filesInfo.OrderByDescending(f => f.Length);
                foreach (var fileInfo in filesInfo) 
                {
                    Console.WriteLine($"--{fileInfo.Name} - {fileInfo.Length / 1024:f3}kb");
                }
            }

            return "";
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(path, textContent);
        }
    }
}
