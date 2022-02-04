using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string monthNum = Console.ReadLine();
            switch (monthNum)
            {
                case "1":
                    monthNum = "January";
                    break;
                case "2":
                    monthNum = "February";
                    break;
                case "3":
                    monthNum = "March";
                    break;
                case "4":
                    monthNum = "April";
                    break;
                case "5":
                    monthNum = "May";
                    break;
                case "6":
                    monthNum = "June";
                    break;
                case "7":
                    monthNum = "July";
                    break;
                case "8":
                    monthNum = "August";
                    break;
                case "9":
                    monthNum = "September";
                    break;
                case "10":
                    monthNum = "October";
                    break;
                case "11":
                    monthNum = "November";
                    break;
                case "12":
                    monthNum = "December";
                    break;
                default:
                    monthNum = "Error!";
                    break;
            }
            Console.WriteLine($"{monthNum}");
        }
    }
}
