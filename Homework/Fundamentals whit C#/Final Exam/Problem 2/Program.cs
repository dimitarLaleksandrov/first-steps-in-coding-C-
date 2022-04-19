using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMesegs = int.Parse(Console.ReadLine());
            string pattern = @"^(\$|\%)([A-Z][a-z]{2,})\1\:\s\[(\d{1,})\]\|\[(\d{1,})\]\|\[(\d{1,})\]\|\n";
            for (int i = 1; i <= numberOfMesegs; i++)
            {
                string mesege = Console.ReadLine();
                Match match = new Regex(pattern).Match(mesege);
                if (match.Success)
                {
                    string name = match.Groups[2].Value;
                    int firstDigit = int.Parse(match.Groups[3].Value);
                    int secondDigit = int.Parse(match.Groups[4].Value);
                    int therdDigit = int.Parse(match.Groups[5].Value);
                    char firstCh = (char)firstDigit;
                    char secondCh = (char)secondDigit;
                    char therdCh = (char)therdDigit;
                    string word = string.Join("", firstCh, secondCh, therdCh);
                    Console.WriteLine($"{name}: {word}");
                    
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
