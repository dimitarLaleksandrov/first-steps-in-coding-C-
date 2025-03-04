

namespace Exercise_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var text = new StreamReader(@"../../../../text.txt"))
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
