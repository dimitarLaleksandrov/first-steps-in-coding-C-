namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var inputFilePath = new StreamReader(@"..\..\..\..\input.txt");
            using var outputFilePath = new StreamWriter(@"..\..\..\..\outputTask2.txt");
            int counter = 1;

            while (true)
            {
                string line = inputFilePath.ReadLine();

                if (line == null) break;
                
                outputFilePath.WriteLine($"{counter}. {line}");
                Console.WriteLine($"{counter}. {line}");

                counter++;
            }
        }
    }
}
