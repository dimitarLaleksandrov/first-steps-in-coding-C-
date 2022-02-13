using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] argumants = comand.Split(" ");
                string comandTipe = argumants[0];
                if (comandTipe == "exchange")
                {
                    int exchangeIdex = int.Parse(argumants[1]);
                    if (exchangeIdex < 0 || exchangeIdex >= input.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    input = ArrayParts(input, exchangeIdex);
                }
                else if (comandTipe == "max")
                {
                    string oddOrEven = argumants[1];
                    int maxIndex = MaxElementofTipe(input, oddOrEven);
                    if (maxIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxIndex);
                    }
                }
                else if (comandTipe == "min")
                {
                    string oddorEven = argumants[1];
                    int minIndex = MinElementofTipe(input,oddorEven);
                    if (minIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }
                else if (comandTipe == "first" || comandTipe == "last")
                {
                    int count = int.Parse(argumants[1]);
                    string oddOrEven = argumants[2];
                    if (count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (comandTipe == "first")
                    {
                        PrintFirstElementsOfType(input, count, oddOrEven);
                    }
                    else
                    {
                        PrintLastElementsOfType(input, count, oddOrEven);
                    }
                }
            }
            Console.WriteLine(ArrayToStringFormat(input, input.Length));
        }
        static int[] ArrayParts(int[] input, int exchange)
        {
            int[] exchaingNum = new int[input.Length];
            int exchNumIdex = 0;
            for (int i = exchange + 1; i < input.Length; i++)
            {
                exchaingNum[exchNumIdex] = input[i];
                exchNumIdex++;
            }
            for (int i = 0; i <= exchange; i++)
            {
                exchaingNum[exchNumIdex] = input[i];
                exchNumIdex++;
            }
            return exchaingNum;
        }
        static int MaxElementofTipe(int[] input, string oddOrEven)
        {
            int index = -1;
            int maxValu = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                int curentNUm = input[i];
                if (oddOrEven == "even")
                {
                    if (curentNUm % 2 == 0 && curentNUm >= maxValu)
                    {
                        maxValu = curentNUm;
                        index = i;
                    }
                }
                else if(oddOrEven == "odd")
                {
                    if (curentNUm % 2 == 1 && curentNUm >= maxValu)
                    {
                        maxValu = curentNUm;
                        index = i;
                    }
                }
            }
            return index;
        }
        static int MinElementofTipe(int[] input, string oddOrEven)
        {
            int index = -1;
            int minValu = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                int curentNUm = input[i];
                if (oddOrEven == "even")
                {
                    if (curentNUm % 2 == 0 && curentNUm <= minValu)
                    {
                        minValu = curentNUm;
                        index = i;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (curentNUm % 2 == 1 && curentNUm <= minValu)
                    {
                        minValu = curentNUm;
                        index = i;
                    }
                }
            }
            return index;
        }
        static void PrintFirstElementsOfType(int[] input, int count, string oddOrEven)
        {
            int[] firstElements = new int[count];
            int firstIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int curentNum = input[i];
                if (oddOrEven == "even")
                {
                    if (curentNum % 2 == 0 && firstIndex < count)
                    {
                        firstElements[firstIndex] = curentNum;
                        firstIndex++;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (curentNum % 2 != 0 && firstIndex < count)
                    {
                        firstElements[firstIndex] = curentNum;
                        firstIndex++;
                    }
                }
            }
            Console.WriteLine(ArrayToStringFormat(firstElements, firstIndex));
        }
        static void PrintLastElementsOfType(int[] input, int count, string oddOrEven)
        {
            int[] lastElements = new int[count];
            int lastIndex = 0;
            for (int i = input.Length -1; i >= 0; i--)
            {
                int curentNum = input[i];
                if (oddOrEven == "even")
                {
                    if (curentNum % 2 == 0 && lastIndex < count)
                    {
                        lastElements[lastIndex] = curentNum;
                        lastIndex++;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (curentNum % 2 != 0 && lastIndex < count)
                    {
                        lastElements[lastIndex] = curentNum;
                        lastIndex++;
                    }
                }
            }
            int[] revesrArray = new int[lastIndex];
            int reversArrayIndex = 0;
            for (int i = lastIndex - 1; i >= 0; i--)
            {
                revesrArray[reversArrayIndex] = lastElements[i];
                reversArrayIndex++;
            }
            Console.WriteLine(ArrayToStringFormat(revesrArray, reversArrayIndex));
        }
        static string ArrayToStringFormat(int[] arr, int elementsCount)
        {
            string output = String.Empty;
            output += "[";
            for (int i = 0; i < elementsCount; i++)
            {
                if (i == elementsCount - 1)
                {
                    output += $"{arr[i]}";
                }
                else
                {
                    output += $"{arr[i]}, ";
                }               
            }
            output += "]";
            return output;
        }
    }
}
