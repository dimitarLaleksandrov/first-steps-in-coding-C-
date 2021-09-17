using System;

namespace int1
{
    class Programo
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a:{0} b:{1} ", a, b);
    }
}
}
