using System;

namespace Task_6
{
    class Task_6
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int firstDigit = int.Parse(num[0].ToString());
            int seconDigit = int.Parse(num[1].ToString());
            int thirdDigit = int.Parse(num[2].ToString());
            for (int i = 1; i <= thirdDigit; i++)
            {
                for (int j = 1; j <= seconDigit; j++)
                {
                    for (int k = 1; k <= firstDigit; k++)
                    {
                        int result = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }
                }
            }
        }
    }
}
