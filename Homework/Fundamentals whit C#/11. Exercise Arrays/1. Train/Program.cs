using System;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        //static void main(string[] args)
        //{
        //    //int wagonsnum = int.parse(console.readline());
        //    //int sumofallpeoles = 0;
        //    //var peoplenum = string.empty;
        //    //for (int i = 1; i <= wagonsnum; i++)
        //    //{
        //    //    int numofpeoples = int.parse(console.readline());
        //    //    sumofallpeoles += numofpeoples;
        //    //    for (int j = numofpeoples; j <= numofpeoples; j++)
        //    //    {
        //    //        peoplenum += j + " ";
        //    //    }
        //    //}
        //    //console.writeline(peoplenum);
        //    //console.writeline(sumofallpeoles);
        //}
        public static void Main()
        {
            int num = 5;
            string a = "Mitko";
            Increment(num, 15, a);
            Console.WriteLine(num);
            Console.WriteLine(a);
        }

        public static void Increment(int num, int value, string b)
        {
            num += value;
            string c = b;
            c = "Kiko";
        }
    }
}
