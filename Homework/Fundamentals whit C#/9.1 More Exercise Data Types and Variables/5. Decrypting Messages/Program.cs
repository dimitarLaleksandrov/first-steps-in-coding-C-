using System;

namespace _5._Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int loopNumber = int.Parse(Console.ReadLine());
            string decodeCode = string.Empty;
            for (int i = 1; i <= loopNumber; i++)
            {
                char input = char.Parse(Console.ReadLine());
                char decodeLetter = (char)(input + key);
                decodeCode += decodeLetter;
            }
            Console.WriteLine(decodeCode);  
        }
    }
}
