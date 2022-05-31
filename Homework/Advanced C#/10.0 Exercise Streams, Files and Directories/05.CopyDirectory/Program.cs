using System;
using System.IO;

namespace _05.CopyDirectory
{
    internal class CopyDirectory
    {
        static void Main(string[] args)
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";
            CopyAllFile(inputPath, outputPath);
        }
        static void CopyAllFile (string inputPath, string outoutPath)
        {
            if (Directory.Exists(inputPath))
            {
                Directory.Delete(outoutPath, true);
            }
            Directory.CreateDirectory(outoutPath);
            var files = Directory.GetFiles(inputPath);
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var copyPlace = Path.Combine(outoutPath, fileName);
                File.Copy(fileName, copyPlace);
            }
        }
    }
}
