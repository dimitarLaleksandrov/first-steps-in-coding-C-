using System.Text;

namespace Text_Processing_Lab_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            StringBuilder sb = new StringBuilder();
            foreach (string word in input) 
            { 
                int count = word.Length;

                for (int i = 0; i < count; i++) 
                {
                    sb.Append(word);
                }

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
