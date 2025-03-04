namespace Exercise_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var text = new StreamReader(@"../../../../text.txt"))
            {
                int counter = 1;
                string line = text.ReadLine();

                while (line != null)
                {
                    int countLetters = line.Count(char.IsLetter);
                    int symbols = line.Count(char.IsPunctuation);
                    Console.WriteLine($"Line {counter}: {line} ({countLetters})({symbols})");

                    counter++;
                    line = text.ReadLine();
                }
            }
        }
    }
}
