using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Core
{
    using IO.Interface;
    using Telephony.Models;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly StationaryPhone stationaryPhone;
        private readonly Smartphone smartPhone;
        private Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartPhone = new Smartphone();
        }
        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            string[] phonenumbers = this.reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] urls = this.reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var number in phonenumbers)
            {
                if (!this.ValidateNumber(number))
                {
                    this.writer.WriteLine("Invalid number!");
                }
                else if(number.Length == 10)
                {
                    this.writer.WriteLine(this.smartPhone.Call(number));
                }
                else if (number.Length == 7)
                {
                    this.writer.WriteLine(this.stationaryPhone.Call(number));
                }
            }
            foreach (var url in urls)
            {
                if (!this.ValidateURL(url))
                {
                    this.writer.WriteLine("Invalid URL!");
                }
                else
                {
                    this.writer.WriteLine(this.smartPhone.BrowseURl(url));
                }
            }
        }
        private bool ValidateNumber(string number)
        {
            foreach (var digit in number)
            {
                if (!Char.IsDigit(digit))
                {
                    return false;
                }
            }
            return true;
        }
        private bool ValidateURL(string url)
        {
            foreach (var ch in url)
            {
                if (Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
