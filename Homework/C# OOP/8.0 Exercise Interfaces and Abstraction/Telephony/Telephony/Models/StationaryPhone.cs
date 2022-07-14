using System;
using System.Collections.Generic;
using System.Text;


namespace Telephony.Models
{
    using Interface;
    public class StationaryPhone : ICalable
    {
        public string Call(string number)
        {
            return $"Dialing... {number}";
        }
    }
}
