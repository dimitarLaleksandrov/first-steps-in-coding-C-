namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var inputFilePath = new StreamReader(@"..\..\..\..\input.txt");
            using var outputFilePath = new StreamWriter(@"..\..\..\..\outputtask1.txt");

            int counter = 0;
                
            while (true)
            {
                string line = inputFilePath.ReadLine();

                if (line == null) break;
                if (counter % 2 != 0)
                {
                    outputFilePath.WriteLine(line);
                    Console.WriteLine($"{line}");

                }

                counter++;
            }
        }
    }
}
