using System;

namespace _6._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopNum = int.Parse(Console.ReadLine());
            int openBracket = 0;
            int closingBracket = 0;
            bool flag = true;
            int point = 0;
            for (int i = 1; i <= loopNum; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    openBracket += 1;
                    point += 1;
                    if (point == 2)
                    {
                        flag = false;
                        point = 0;
                    }
                }
                else if (input == ")")
                {
                    closingBracket += 1;
                    point = 0;
                } 
            }
            if (openBracket == closingBracket && flag == true)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
