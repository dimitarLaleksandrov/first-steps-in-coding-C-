using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tasksStakInput = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            var threadsQueuesInput = new List<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int valueOfTheTask = int.Parse(Console.ReadLine());
            var kiledTask = 0;
            while (true)
            {
                var threadValue = threadsQueuesInput[0];
                var taskValue = tasksStakInput.Peek();
                if (taskValue == valueOfTheTask)
                {
                    kiledTask = threadValue;
                    break;
                }
                if (threadValue > taskValue || threadValue < taskValue || threadValue == taskValue)
                {
                    threadsQueuesInput.Remove(threadValue);
                }
                if (threadValue >= taskValue)
                {
                    tasksStakInput.Pop();
                } 
            }
            Console.WriteLine($"Thread with value {kiledTask} killed task {valueOfTheTask}");
            Console.WriteLine(string.Join(" ", threadsQueuesInput));
        }
    }
}
