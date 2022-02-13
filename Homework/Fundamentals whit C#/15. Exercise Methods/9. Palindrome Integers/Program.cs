using System;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isPalindrome = false;
            while (input != "END")
            {
                Console.WriteLine(IsItPalindrome(input, isPalindrome));
                input = Console.ReadLine();
            }
        }
        static bool IsItPalindrome(string input, bool isPalindrome)
        {
            string reversNum = String.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                char symbol = input[i];
                reversNum += symbol;
            }
            if (reversNum == input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
