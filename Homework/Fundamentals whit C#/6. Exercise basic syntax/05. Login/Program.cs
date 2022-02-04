using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string pass = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                pass += userName[i];
            }
            for (int counter = 1; counter <= 4; counter++)
            {
                string passTray = Console.ReadLine();
                if (passTray == pass)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        continue;
                    }
                }
            }
        }
    }
}
