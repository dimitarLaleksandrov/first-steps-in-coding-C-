using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands;
            while ((commands = Console.ReadLine()) != "Done")
            {
                string[] comArg = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = comArg[0];
                if (command == "Change")
                {
                    string charToChange = comArg[1];
                    string charWhit = comArg[2];
                    input = input.Replace(charToChange, charWhit);
                    Console.WriteLine(input);
                }
                else if (command == "Includes")
                {
                    string substring = comArg[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "End")
                {
                    string substring = comArg[1];
                    if (input.EndsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (command == "FindIndex")
                {
                    string charToFind = comArg[1];
                    int indexToPrint = input.IndexOf(charToFind);
                    Console.WriteLine(indexToPrint);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(comArg[1]);
                    int indexToCut = int.Parse(comArg[2]);
                    input = input.Substring(startIndex, indexToCut);
                    Console.WriteLine(input);
                }
            }

        }
    }
}
