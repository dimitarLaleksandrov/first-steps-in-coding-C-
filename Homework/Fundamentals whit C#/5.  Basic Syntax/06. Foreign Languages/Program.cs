using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "USA":
                    input = "English";
                    break;
                case "England":
                    input = "English";
                    break;
                case "Spain":
                    input = "Spanish";
                    break;
                case "Argentina":
                    input = "Spanish";
                    break;
                case "Mexico":
                    input = "Spanish";
                    break;
                default:
                    input = "unknown";
                    break;
            }
            Console.WriteLine($"{input}");
        }
    }
}
