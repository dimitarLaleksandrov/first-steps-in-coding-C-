using System;
using System.Linq;
using System.Text;

namespace Problem_1___Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // whit substring
            string activationKey = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArray = command.Split(">>>");
                if (commandArray[0] == "Contains")
                {
                    string substring = commandArray[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else if (activationKey.Contains(substring) == false)
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (commandArray[0] == "Flip")
                {
                    if (commandArray[1] == "Upper")
                    {
                        int startIndex = int.Parse(commandArray[2]);
                        int endIndex = int.Parse(commandArray[3]);
                        int validStartIndex = Math.Max(0, startIndex);
                        int validEndInex = Math.Min(activationKey.Length - 1, endIndex);
                        if (validEndInex >= validStartIndex)
                        {
                            int subtringToReplaceLength = endIndex - startIndex;
                            string substringToReplace = activationKey.Substring(startIndex, subtringToReplaceLength);
                            string newString = substringToReplace.ToUpper();
                            activationKey = activationKey.Replace(substringToReplace, newString);
                        }
                        Console.WriteLine(activationKey);
                    }
                    else if (commandArray[1] == "Lower")
                    {
                        int startIndex = int.Parse(commandArray[2]);
                        int endIndex = int.Parse(commandArray[3]);
                        int validStartIndex = Math.Max(0, startIndex);
                        int validEndInex = Math.Min(activationKey.Length - 1, endIndex);
                        if (validEndInex >= validStartIndex)
                        {
                            int subtringToReplaceLength = endIndex - startIndex;
                            string substringToReplace = activationKey.Substring(validStartIndex, subtringToReplaceLength);
                            string newString = substringToReplace.ToLower();
                            activationKey = activationKey.Replace(substringToReplace, newString);
                        }
                        Console.WriteLine(activationKey);
                    }
                }
                else if (commandArray[0] == "Slice")
                {
                    int startIndex = int.Parse(commandArray[1]);
                    int endIndex = int.Parse(commandArray[2]);
                    int validStartIndex = Math.Max(0, startIndex);
                    int validEndIndex = Math.Min(activationKey.Length - 1, endIndex);
                    if (validEndIndex >= validStartIndex)
                    {
                        int substringToRemoveLength = validEndIndex - validStartIndex;
                        string substringToRemove = activationKey.Substring(validStartIndex, substringToRemoveLength);
                        activationKey = activationKey.Replace(substringToRemove, new string(""));
                    }
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: { activationKey}");

            //whit stringBuilder
            //string activationKey = Console.ReadLine();
            //StringBuilder sb = new StringBuilder(activationKey);
            //string command = string.Empty;
            //while ((command = Console.ReadLine()) != "Generate")
            //{
            //    string[] commandArray = command.Split(">>>");
            //    if (commandArray[0] == "Contains")
            //    {
            //        string substring = commandArray[1];
            //        if (sb.ToString().Contains(substring))
            //        {
            //            Console.WriteLine($"{sb} contains {substring}");
            //        }
            //        else if (sb.ToString().Contains(substring) == false)
            //        {
            //            Console.WriteLine($"Substring not found!");
            //        }
            //    }
            //    else if (commandArray[0] == "Flip")
            //    {
            //        if (commandArray[1] == "Upper")
            //        {
            //            int startIndex = int.Parse(commandArray[2]);
            //            int endIndex = int.Parse(commandArray[3]);
            //            int validStartIndex = Math.Max(0, startIndex);
            //            int validEndIndex = Math.Min(sb.Length - 1, endIndex);
            //            if (validEndIndex >= validStartIndex)
            //            {
            //                for (int i = validStartIndex; i < validEndIndex; i++)
            //                {
            //                    sb[i] = char.Parse(sb[i].ToString().ToUpper());
            //                }
            //            }
            //            Console.WriteLine(sb);
            //        }
            //        else if (commandArray[1] == "Lower")
            //        {
            //            int startIndex = int.Parse(commandArray[2]);
            //            int endIndex = int.Parse(commandArray[3]);
            //            int validStartIndex = Math.Max(0, startIndex);
            //            int validEndIndex = Math.Min(sb.Length - 1, endIndex);
            //            if (validEndIndex >= validStartIndex)
            //            {
            //                for (int i = validStartIndex; i < validEndIndex; i++)
            //                {
            //                    sb[i] = char.Parse(sb[i].ToString().ToLower());
            //                }
            //            }
            //            Console.WriteLine(sb);
            //        }
            //    }
            //    else if (commandArray[0] == "Slice")
            //    {
            //        int startIndex = int.Parse(commandArray[1]);
            //        int endIndex = int.Parse(commandArray[2]);
            //        int validStartIndex = Math.Max(0, startIndex);
            //        int validEndIndex = Math.Min(sb.Length - 1, endIndex);
            //        if (validEndIndex >= validStartIndex)
            //        {
            //            int lengthToRemove = validEndIndex - validStartIndex;
            //            sb.Remove(validStartIndex, lengthToRemove);
            //        }
            //        Console.WriteLine(sb);
            //    }
            //}
            //Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
