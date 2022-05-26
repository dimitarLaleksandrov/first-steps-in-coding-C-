using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class ProductShop
    {
      
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, decimal>> shops = new SortedDictionary<string, Dictionary<string, decimal>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");
                if (input[0] == "Revision")
                {
                    break;
                }
                string shopName = input[0];
                string productName = input[1];
                decimal price = decimal.Parse(input[2]);
                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, decimal>());
                    shops[shopName].Add(productName, price);
                }
                else
                {
                    if (!shops[shopName].ContainsKey(productName))
                    {
                        shops[shopName].Add(productName, price);
                    }
                    else
                    {
                        shops[shopName][productName] = price;
                    }
                    
                }
            }
            foreach (var shopsAndProdukts in shops)
            {
                string shop = shopsAndProdukts.Key;
                var productPrice = shopsAndProdukts.Value;
                Console.WriteLine($"{shop}->");
                foreach (var product in productPrice)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value:f1}");
                }
            } 
        }
    }
}
