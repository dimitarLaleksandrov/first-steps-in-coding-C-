namespace Text_Processing_Exercise_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            //string[] sorted = userNames.Where(x => x.Length > 3 && x.Length < 16)
            //     .Where(x => x.All(x => char.IsLetterOrDigit(x) || x.Equals('_') || x.Equals('-'))).ToArray();

            foreach (string userName in userNames)
            {
                if(ISValid(userName))
                {
                    Console.WriteLine(userName);
                }
            }

        }
        public static bool ISValid(string userName)
        {
            return IsvalidLenght(userName) && ContainsValidSymbols(userName);
        }

        public static bool IsvalidLenght(string userName) 
        { 
            return userName.Length >= 3 && userName.Length <= 16;
        }

        public static bool ContainsValidSymbols(string userName) 
        {
            foreach (char symbol in userName) 
            { 
                if (!char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                {
                    return false;
                }
            } 
            return true;
        }

    }
}
