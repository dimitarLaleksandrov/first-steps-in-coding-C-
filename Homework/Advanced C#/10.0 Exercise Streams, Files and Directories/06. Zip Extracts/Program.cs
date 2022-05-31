using System;
using System.IO;
using System.IO.Compression;

namespace _06._Zip_Extracts
{
    internal class ZipExtracts
    {
        static void Main(string[] args)
        {
            string inputFile = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\copyMe.png";
            string zipFile = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\arhive.zip";
            string extraktFile = @"D:\Coding\Programing with C#\first-steps-in-coding-C-\Homework\Advanced C#\10.0 Exercise Streams, Files and Directories\extrakted.png";
            ArhiveZipFile(inputFile, zipFile);
            var fileName = Path.GetFileName(inputFile);
            ExtraktFile(zipFile, fileName, extraktFile);

        }
        public static void ArhiveZipFile (string inputFile, string zipFile)
        {
            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                string fileName = Path.GetFileName(inputFile);
                archive.CreateEntryFromFile(inputFile, fileName);
            }
        }
        public static void ExtraktFile (string zipFile, string fileName, string extraktedFiles)
        {
            var archive = ZipFile.OpenRead(zipFile);
            var extraktionFile = archive.GetEntry(fileName);
            extraktionFile.ExtractToFile(extraktedFiles);
        }
    }
}
