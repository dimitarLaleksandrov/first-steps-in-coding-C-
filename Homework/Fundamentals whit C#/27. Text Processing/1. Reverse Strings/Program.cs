using System;
using System.Linq;

namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            while ((word = Console.ReadLine()) != "end")
            {
                string revurseWord = new string(word.Reverse().ToArray());
                Console.WriteLine($"{word} = {revurseWord}");
            }
        }
    }
}
