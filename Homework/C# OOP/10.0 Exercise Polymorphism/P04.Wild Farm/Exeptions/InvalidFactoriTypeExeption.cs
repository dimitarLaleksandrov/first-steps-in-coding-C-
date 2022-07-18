using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Exeptions
{
    public class InvalidFactoriTypeExeption : Exception
    {
        private const string DefaultMessage = "Invalid Type";
        public InvalidFactoriTypeExeption() : base(DefaultMessage)
        {

        }
        public InvalidFactoriTypeExeption(string message) : base(message)
        {

        }
    }
}
