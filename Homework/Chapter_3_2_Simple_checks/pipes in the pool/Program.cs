using System;

namespace pipes_in_the_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pool Liters :");
            int poolVolume = int.Parse(Console.ReadLine());
            Console.Write("Pipe one flow :");
            int flowPipeOne = int.Parse(Console.ReadLine());
            Console.Write("Pipe two flow :");
            int flowPipeTwo = int.Parse(Console.ReadLine());
            Console.Write("Hours :");
            double hoursWorkerAbsent = double.Parse(Console.ReadLine());
            double waterFull = Math.Floor((flowPipeOne * hoursWorkerAbsent) + (flowPipeTwo * hoursWorkerAbsent));
            if(poolVolume >= waterFull)
            {
                double waterPercent = Math.Floor((waterFull / poolVolume) * 100);
                double pipeOnePercent = Math.Floor(((flowPipeOne * hoursWorkerAbsent) / waterFull) *100);
                double pipeTwoPercent = Math.Floor(((flowPipeTwo * hoursWorkerAbsent) / waterFull) * 100);
                Console.WriteLine($"The pool is {waterPercent}% full. Pipe1:{pipeOnePercent}%.Pipe2:{pipeTwoPercent}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursWorkerAbsent} hours the pool overflows with {waterFull - poolVolume} liters.");
            }
        }
    }
}
