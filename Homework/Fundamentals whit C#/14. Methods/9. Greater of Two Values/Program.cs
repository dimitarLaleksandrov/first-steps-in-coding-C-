using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxMethod(first, second));
                    break;
                case "char":
                    char f = char.Parse(Console.ReadLine());
                    char s = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxMethod(f, s));
                    break;
                case "string":
                    string fir = Console.ReadLine();
                    string sec = Console.ReadLine();
                    Console.WriteLine(GetMaxMethod(fir, sec));
                    break;
                default:
                    break;
            }
        }
        static int GetMaxMethod(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMaxMethod(char f, char s)
        {
            return (f > s) ? f : s;
            //  if , else == ?
            // short stuff ;
        }
        static string GetMaxMethod(string fir, string sec)
        {
            if (fir.CompareTo(sec) > 0)
            {
                return fir;
            }
            else
            {
                return sec;
            }
        }
    }
}
