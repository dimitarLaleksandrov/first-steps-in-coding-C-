using System;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wordResolt = MiddelLength(word);
            Console.WriteLine(wordResolt);
        }
        static string MiddelLength(string word)
        {
            int length = word.Length;
            string resolt = String.Empty;
            if (length % 2 == 1)
            {
                resolt = word[word.Length / 2].ToString();
            }
            else
            {
                resolt = word[word.Length / 2 - 1].ToString() + word[word.Length / 2].ToString();
            }
            return resolt;
        }
    }
}
