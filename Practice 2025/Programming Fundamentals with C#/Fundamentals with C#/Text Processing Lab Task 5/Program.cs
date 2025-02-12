using System.Text;

namespace Text_Processing_Lab_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            StringBuilder nums = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            foreach (char c in input) 
            {
                if (char.IsDigit(c))
                {
                    nums.Append(c);
                }
                else if (char.IsLetter(c)) 
                { 
                    letters.Append(c);
                }
                else
                {
                    symbols.Append(c);
                }
            }

            Console.WriteLine(nums.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(symbols.ToString());


        }
    }
}
