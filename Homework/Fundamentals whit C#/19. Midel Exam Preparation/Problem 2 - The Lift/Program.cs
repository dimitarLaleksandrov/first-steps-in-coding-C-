using System;
using System.Linq;

namespace Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxPplInLift = 4;
            int peopleNumber = int.Parse(Console.ReadLine());
            int[] stateOfTheLift = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int curentPplNum = peopleNumber;
            int pplMove = 0;
            int stayPpl = 0;
            int pplInLastLift = 0;
            for (int i = 0; i < stateOfTheLift.Length; i++)
            {
                if (stateOfTheLift[i] == 0)
                {
                    stateOfTheLift[i] = maxPplInLift;
                }
                else if (stateOfTheLift[i] > 0)
                {
                    pplMove += stateOfTheLift[i];
                    stateOfTheLift[i] = maxPplInLift;
                }
                if (curentPplNum < maxPplInLift)
                {
                    //if (pplMove != 0)
                    //{
                    //    stayPpl = (pplMove + peopleNumber) - (stateOfTheLift.Length * maxPplInLift);
                    //}
                    stateOfTheLift[i] = curentPplNum;
                }   
                curentPplNum -= stateOfTheLift[i];
                if (curentPplNum == 0 && pplMove != 0)
                {
                    pplInLastLift = stateOfTheLift[i];
                    stateOfTheLift[i] = maxPplInLift;
                }
            }
            if (curentPplNum > maxPplInLift && curentPplNum == 0)
            {
                curentPplNum = pplMove - pplInLastLift;
                Console.WriteLine($"There isn't enough space! {curentPplNum} people in a queue!");
                Console.WriteLine(String.Join(" ", stateOfTheLift));
            }
            else
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(String.Join(" ", stateOfTheLift));
            }
           
        }
    }
}
