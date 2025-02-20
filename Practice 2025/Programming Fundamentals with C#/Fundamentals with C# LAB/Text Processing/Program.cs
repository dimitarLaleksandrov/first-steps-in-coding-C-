namespace Text_Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while (input != "end")
            {
                input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }
                string reversedInput = string.Empty;
                for (int i = input.Length -1; i >= 0; i--)
                {
                    reversedInput += input[i];
                }
                Console.WriteLine($"{input} = {reversedInput}");
            }

        }
    }
}
