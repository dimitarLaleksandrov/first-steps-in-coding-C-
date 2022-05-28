using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    internal class WordCount
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordAndFrequency = new Dictionary<string, int>();
            string[] words = File.ReadAllText("words.txt").Split();

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    string[] wordsInCurrentLine = currentLine.ToLower()
                    .Split(new char[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        foreach (var item in wordsInCurrentLine)
                        {
                            if (word == item)
                            {
                                if (!wordAndFrequency.ContainsKey(item))
                                {
                                    wordAndFrequency.Add(item, 0);
                                }
                                wordAndFrequency[item]++;
                            }
                        }
                    }
                    currentLine = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var item in wordAndFrequency.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
