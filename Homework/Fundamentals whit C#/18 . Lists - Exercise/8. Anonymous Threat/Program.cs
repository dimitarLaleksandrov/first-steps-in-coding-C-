using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] comandArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string comandTipe = comandArguments[0];
                if (comandTipe == "merge")
                {
                    int startIndex = int.Parse(comandArguments[1]);
                    int endIndex = int.Parse(comandArguments[2]);
                    Merge(input, startIndex, endIndex);
                }
                else if (comandTipe == "divide")
                {
                    int index = int.Parse(comandArguments[1]);
                    int partishanCOunt = int.Parse(comandArguments[2]);
                    Divide(input, index, partishanCOunt);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
        static void Merge(List<string> words, int startIndex, int endIndex)
        {
            if (!IsIndexValid(words, startIndex))
            {
                startIndex = 0;
            }
            if (!IsIndexValid(words, endIndex))
            {
                endIndex = words.Count - 1;
            }
            StringBuilder merge = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                merge.Append(words[startIndex]);
                words.RemoveAt(startIndex);
            }
            words.Insert(startIndex, merge.ToString());
            // no stringBilder
            // List<string> mergeList = new List<string>();
            // for(int i = startIndex; i <= endIndex; i++)
            //{
            //   mergeList.Add(words[startIndex]);
            //   words.RemoveAt(startIndex);
            //}
            // string merge = String.Join("", mergeList);
            // words.Insert(startIndex, merge);
        }
        static bool IsIndexValid(List<string> words, int index)
        {
            return index >= 0 && index < words.Count;
        }
        static void Divide(List<string> words, int elementIndex, int partitionsCount)
        {
            string word = words[elementIndex];
            if (partitionsCount > word.Length)
            {
                return;
            }
            int partitionsLength = word.Length / partitionsCount;
            int partitionsReminder = word.Length % partitionsCount;
            int lastPartitionsLength = partitionsReminder + partitionsLength;
            List<string> partitions = new List<string>();
            for (int i = 0; i < partitionsCount; i++)
            {
                char[] curentPartition;
                if (i == partitionsCount)
                {
                    curentPartition = word.Skip(i * partitionsLength).Take(lastPartitionsLength).ToArray();
                }
                else
                {
                    curentPartition = word.Skip(i * partitionsLength).Take(partitionsLength).ToArray();
                }
                partitions.Add(new string(curentPartition));
            }
            words.RemoveAt(elementIndex);
            words.InsertRange(elementIndex, partitions);
        }
    }
}
