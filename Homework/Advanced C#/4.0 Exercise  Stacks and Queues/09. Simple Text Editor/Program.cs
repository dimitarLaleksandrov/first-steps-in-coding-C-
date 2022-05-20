using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> textHistory = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if (command.StartsWith("1"))
                {
                    textHistory.Push(text.ToString());
                    string textToAdd = command.Split(' ')[1];
                    text.Append(textToAdd);
                }
                else if (command.StartsWith("2"))
                {
                    textHistory.Push(text.ToString());
                    int indexToRemuve = int.Parse(command.Split(' ')[1]);
                    text.Remove(text.Length - indexToRemuve, indexToRemuve);
                }
                else if (command.StartsWith("3"))
                {
                    int index = int.Parse(command.Split(' ')[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command.StartsWith("4"))
                {
                    text = new StringBuilder(textHistory.Pop());
                }
            }
        }
    }
}
