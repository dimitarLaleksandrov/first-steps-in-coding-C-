using System;

namespace Hello_World
{
    public class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
        }

        public static string HelloWorld()
        {
            string a = "Hello";
            string b = "World";
            object c = a + " " + b;
            string d = c.ToString();
            return d;
        }
    }
}
