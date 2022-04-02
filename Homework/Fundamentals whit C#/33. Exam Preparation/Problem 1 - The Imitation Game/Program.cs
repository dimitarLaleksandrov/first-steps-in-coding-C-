using System;
using System.Linq;

namespace Problem_1___The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meseg = Console.ReadLine();
            string commands;
            while ((commands = Console.ReadLine()) != "Decode")
            {
                string[] instructions = commands.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = instructions[0];
                if (action == "Move")
                {
                    int indexToMove = int.Parse(instructions[1]);
                    string mesegToRemove = meseg.Remove(indexToMove);
                    string sumstring = meseg.Substring(indexToMove);
                    meseg = string.Join("", sumstring, mesegToRemove);
                }
                else if (action == "Insert")
                {
                    int indexToInsert = int.Parse(instructions[1]);
                    string value = instructions[2];
                    meseg = meseg.Insert(indexToInsert, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = instructions[1];
                    string reolaceString = instructions[2];
                    meseg = meseg.Replace(substring, reolaceString);
                }
            }
            Console.WriteLine($"The decrypted message is: {meseg}");
        }
    }
}
