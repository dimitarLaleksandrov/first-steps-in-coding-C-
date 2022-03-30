using System;
using System.Linq;

namespace Problem_1___Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] commandArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];
                if (commandType == "TakeOdd")
                {
                    // taking the oddd index whit LINQ
                    char[] oddChar = password.Where((symbol, index) => index % 2 != 0 ).ToArray();
                    password = string.Join("", oddChar);
                    Console.WriteLine(password);
                }
                else if (commandType == "Cut")
                {
                    int indexForRemuving = int.Parse(commandArg[1]);
                    int lentForRemuving = int.Parse(commandArg[2]);
                    password = password.Remove(indexForRemuving, lentForRemuving);
                    Console.WriteLine(password);
                }
                else if (commandType == "Substitute")
                {
                    string substring  = commandArg[1];
                    string substitute = commandArg[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
