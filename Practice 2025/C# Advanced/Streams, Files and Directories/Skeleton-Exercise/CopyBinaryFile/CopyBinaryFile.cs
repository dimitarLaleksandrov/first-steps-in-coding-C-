namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (var input = new FileStream(inputFilePath, FileMode.Open))
            {
                using (var output = new FileStream(outputFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    int readBytes;
                    while ((readBytes = input.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        output.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
