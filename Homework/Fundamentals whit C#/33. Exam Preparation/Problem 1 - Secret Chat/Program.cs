using System;
using System.Linq;

namespace Problem_1___Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine(); 
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commandArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArgs[0];
                if (commandType == "InsertSpace")
                {
                    int intToInsert = int.Parse(commandArgs[1]);
                    message = message.Insert(intToInsert, " ");
                }
                else if (commandType == "Reverse")
                {
                    string reverseString = commandArgs[1];
                    if (message.Contains(reverseString))
                    {
                        int wordIndex = message.IndexOf(reverseString);
                        message = message.Remove(wordIndex, reverseString.Length);
                        message += string.Join("", reverseString.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    
                }
                else if (commandType == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replaistmentText = commandArgs[2];
                    message = message.Replace(substring, replaistmentText);
                }
                Console.WriteLine(message);
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
