namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            ProcessLines(inputFilePath);
        }

        public static void ProcessLines(string inputFilePath)
        {
            using (var text = new StreamReader(inputFilePath))
            {
                int counter = 0;
                string line = text.ReadLine();

                while (line != null)
                {
                    counter++;
                    if (counter % 2 != 0)
                    {
                        line = Replace(line);
                        line = Reverse(line);
                        Console.WriteLine(line);
                    }

                    line = text.ReadLine();
                }
            }   
        }

        private static string Reverse(string line)
        {
            return string.Join(" ", line.Split().Reverse());
        }

        private static string Replace(string line)
        {
            return line.Replace("-", "@").Replace(',', '@').Replace('.', '@').Replace(',', '@').Replace('!', '@').Replace(',', '@').Replace('?', '@');
        }
    }
}
