using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Flower_Wreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int valueToGoal = 15;
            const int toGoalWreath = 5;
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int wreath = 0;
            int storedFlowersSum = 0;
            while (lilies.Count > 0 && roses.Count > 0)
            {
                var liliesValue = lilies.Peek();
                var rosesValue = roses.Peek();
                if (liliesValue + rosesValue == valueToGoal)
                {
                    wreath++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (liliesValue + rosesValue > valueToGoal)
                {
                    var sum = liliesValue + rosesValue;
                    while(sum > valueToGoal)
                    {
                        sum -= 2;
                    }
                    lilies.Pop();
                    roses.Dequeue();
                    wreath++;
                }
                else
                {
                    var sum = liliesValue + rosesValue;
                    lilies.Pop();
                    roses.Dequeue();
                    storedFlowersSum += sum;
                }
            }
            while (storedFlowersSum >= valueToGoal)
            {
                storedFlowersSum -= valueToGoal;
                wreath++;
            }
            if (wreath >= toGoalWreath)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
            }
            else
            {
                var sumNeedet = toGoalWreath - wreath;
                Console.WriteLine($"You didn't make it, you need {sumNeedet} wreaths more!");
            }
        }
    }
}
