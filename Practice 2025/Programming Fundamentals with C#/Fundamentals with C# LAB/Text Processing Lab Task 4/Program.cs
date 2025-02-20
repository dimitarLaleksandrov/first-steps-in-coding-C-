namespace Text_Processing_Lab_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine(); 
            
            foreach (string word in words) 
            {
                input = input.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(input);

        }
    }
}
