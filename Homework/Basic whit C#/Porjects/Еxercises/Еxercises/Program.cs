using System;
using System.Collections.Generic;

namespace Еxercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort ushortVariable = 52130;
            sbyte sbyteVaribale = -115;
            int intVaribale = 4825932;
            sbyte sbyteVaribale97 = 97;
            short shortVaribale = -10000;
            short shortVaribale20k = 20000;
            byte byteVaribale = 224;
            int intVariabale = 970700000;
            sbyte sbyteVaribale112 = 112;
            sbyte sbyteVaribale_44 = -44;
            int intVaribaleMinus = -1000000;
            short shortVaribale1990 = 1990;
            ulong ulongVaribale = 123456789123456789;

            List<object> objectsArray = new List<object>();
            objectsArray.Add(ushortVariable);
            objectsArray.Add(sbyteVaribale);

            foreach (var item in objectsArray)
            {
                PrintToConsole(item);
            }

            //Console.WriteLine(52130 + "=" + "ushort");
            //Console.WriteLine(-115 + "=" + "sbyte");
            //Console.WriteLine(4825932 + "=" + "int");
            //Console.WriteLine(97 + "=" + "sbyte");
            //Console.WriteLine(-10000 + "=" + "short");
            //Console.WriteLine(20000 + "=" + "short");
            //Console.WriteLine(224 + "=" + "byte");
            //Console.WriteLine(970700000 + "=" + "int");
            //Console.WriteLine(112 + "=" + "sbyte");
            //Console.WriteLine(-44 + "=" + "sbyte");
            //Console.WriteLine(-1000000 + "=" + "int");
            //Console.WriteLine(1990 + "=" + "short");
            //Console.WriteLine(123456789123456789 + "=" + "ulong");
        }

        static void PrintToConsole(object variable)
        {
            Console.WriteLine($"Value is: {variable}\nType is:{variable.GetType()}");
        }
    }
}
