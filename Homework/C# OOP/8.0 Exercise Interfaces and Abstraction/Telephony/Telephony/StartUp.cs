﻿using System;
using Telephony.Core;
using Telephony.IO;
using Telephony.IO.Interface;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
