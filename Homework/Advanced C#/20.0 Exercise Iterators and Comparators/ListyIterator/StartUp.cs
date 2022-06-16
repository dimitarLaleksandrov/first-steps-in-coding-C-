using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listy = null;
            string cmd = " ";
            while ((cmd = Console.ReadLine()) != "END")
            {
                var input = cmd.Split(' ');
                if (input[0] == "Create")
                {
                    listy = new ListyIterator<string>(input.Skip(1).ToArray());
                }
                else if (input[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (input[0] == "Print")
                {
                    listy.Print();
                }
                else if (input[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if(input[0] == "PrintAll")
                {
                    listy.PrintAll();
                }
            }
        }
    }
}
