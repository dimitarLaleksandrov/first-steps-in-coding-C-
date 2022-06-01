using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            string[] msg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> isurstCharCapital = (string x) => x.Length > 0 && char.IsUpper(x[0]);
            Console.WriteLine(string.Join("\n", msg.Where(x => isurstCharCapital(x)).ToArray()));
        }
    }
}
