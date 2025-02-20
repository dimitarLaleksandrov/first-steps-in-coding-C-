namespace Exercise_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int result = MultiplyWords(words[0], words[1]);
            Console.WriteLine(result);
        }

        public static int MultiplyWords(string first, string second)
        {
            int minLenght = Math.Min(first.Length, second.Length);

            int sum = 0;

            for (int i = 0; i < minLenght; i++) 
            {
                sum += first[i] * second[i];
            }
            if (first.Length > second.Length)
            {
                sum += SumRestChar(first);
            }
            else if(second.Length > first.Length)
            {
                sum += SumRestChar(second);
            }

            return sum;

        }

        public static int SumRestChar(string word) 
        {

        }
    }
}
