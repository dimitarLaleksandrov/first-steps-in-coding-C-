using System;
using System.Text;

namespace _7.__String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                }
                else if (power > 0)
                {
                    input = input.Remove(i, 1);
                    power--;
                    i--;
                }
            }
            Console.WriteLine(input);



            //string inputStr = Console.ReadLine();
            //StringBuilder outputTex = new StringBuilder();
            //int bombPower = 0;
            //for (int i = 0; i < inputStr.Length; i++)
            //{
            //    char curentChar = inputStr[i];
            //    if (curentChar == '>')
            //    {
            //        outputTex.Append(curentChar);
            //        int curentBombPower = GetIntValue(inputStr[i + 1]);
            //        bombPower += curentBombPower;
            //    }
            //    else
            //    {
            //        if (bombPower > 0)
            //        {
            //            bombPower--;
            //        }
            //        else
            //        {
            //            outputTex.Append(curentChar);
            //        }
            //    }
            //}
            //Console.WriteLine(outputTex.ToString());
        }
        //static int GetIntValue (char ch)
        //{
        //    return (int)ch - '0';
        //}
    }
}
