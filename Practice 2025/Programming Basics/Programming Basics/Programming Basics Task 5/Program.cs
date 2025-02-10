namespace Programming_Basics_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggCount = int.Parse(Console.ReadLine());
            int secondPlayerEggCount = int.Parse(Console.ReadLine());
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End of battle")
            {
                if (input == "one")
                {
                    secondPlayerEggCount--;
                    if (secondPlayerEggCount == 0)
                    {
                        break;
                    }              
                }
                else if (input == "two") 
                {
                    firstPlayerEggCount--;
                    if (firstPlayerEggCount == 0)
                    {
                        break;
                    }
                }
            }
            if (firstPlayerEggCount <= 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggCount} eggs left.");
            }
            else if (secondPlayerEggCount <= 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggCount} eggs left.");

            }
            else
            {
                Console.WriteLine($"Player one has {firstPlayerEggCount} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggCount} eggs left.");

            }

        }
    }
}
