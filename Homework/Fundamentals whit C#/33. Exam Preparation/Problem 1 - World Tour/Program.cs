using System;

namespace Problem_1___World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string commandInfo;
            while ((commandInfo = Console.ReadLine()) != "Travel")
            {
                string[] commandArg = commandInfo.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string commandTipe = commandArg[0];
                if (commandTipe == "Add Stop")
                {
                    int insertIndex = int.Parse(commandArg[1]);
                    string insertString = commandArg[2];
                    word = InsertStringAtIndex(word, insertIndex, insertString);
                    Console.WriteLine(word);
                }
                else if (commandTipe == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);
                    word = RemuveStringInRang(word, startIndex, endIndex);
                    Console.WriteLine(word);
                }
                else if (commandTipe == "Switch")
                {
                    string oldString = commandArg[1];
                    string newString = commandArg[2];
                    word = ReplaceAllOccurances(word, oldString, newString);
                    Console.WriteLine(word);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {word}");
        }
        static string InsertStringAtIndex(string word, int insertIndex, string insertString)
        {
            if (!ValidetIndex(word, insertIndex))
            {
                return word;
            }
            string newString = word.Insert(insertIndex, insertString);
            return newString;
        }
        static string RemuveStringInRang(string word, int startIndex, int endIndex)
        {
            if (!ValidetIndex(word, startIndex))
            {
                return word;
            }
            if (!ValidetIndex(word, endIndex))
            {
                return word;
            }
            string newString = word.Remove(startIndex, endIndex - startIndex + 1);
            return newString;
        }
        static string ReplaceAllOccurances(string word, string oldString, string newString)
        {
            string modifidString = word;           
            modifidString = modifidString.Replace(oldString, newString);
            return modifidString;
        }
        static bool ValidetIndex(string str, int index)
        {
            return index >= 0 && index < str.Length;
        }
    }
}
