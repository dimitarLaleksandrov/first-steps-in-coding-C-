using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models
{
    using Interface;
    public class Smartphone : ICalable, IBrowseble
    {
        public string BrowseURl(string url)
        {
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            return $"Calling... {number}";
        }
    }
}
