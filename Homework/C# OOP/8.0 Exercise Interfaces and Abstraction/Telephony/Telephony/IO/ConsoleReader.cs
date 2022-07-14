using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.IO
{
    using Interface;
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            string text  = Console.ReadLine();
            return text;
        }
    }
}
