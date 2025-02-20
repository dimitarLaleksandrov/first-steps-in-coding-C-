using System.Diagnostics.Metrics;

namespace Taks_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, int>();
            string inputWords = File.ReadAllText(@"..\..\..\..\words.txt");
            string[] words = inputWords.Split();
            using var writer = new StreamWriter(@"..\..\..\..\outputtask3.txt");

            using (var reader = new StreamReader(@"..\..\..\..\text.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    foreach (var word in words)
                    {
                        if (line.ToLower().Contains(word))
                        {

                            if (!dictionary.ContainsKey(word))
                            {
                                dictionary.Add(word, 0);
                                dictionary[word]++;
                            }
                            else
                            {
                                dictionary[word]++;
                            }
                        }
                    }

                    line = reader.ReadLine();
                }

                foreach (var word in dictionary.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{word.Key} - {word.Value}");
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
