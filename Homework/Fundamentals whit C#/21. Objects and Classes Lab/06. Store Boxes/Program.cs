using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
     class Item
    {
        public string Nmae { get; set; }
        public decimal Price { get; set; }
    }
     class Box
    {
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
        public decimal BoxTotalPrice { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Box> boxes = new List<Box>();
            while (data[0] != "end")
            {
                int serialNumber = int.Parse(data[0]);
                string item = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);
                Box box = new Box();
                {
                    box.SerialNumber = serialNumber;
                    box.Item = item;
                    box.ItemQuantity = itemQuantity;
                    box.PriceForBox = itemPrice;
                    box.BoxTotalPrice = itemPrice * itemQuantity;
                }
                boxes.Add(box);
                data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            List<Box> sortedBoxe = boxes.OrderByDescending(box => box.BoxTotalPrice).ToList();
            foreach (Box box in sortedBoxe)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceForBox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxTotalPrice:f2}");
            }
        }
    }
}
