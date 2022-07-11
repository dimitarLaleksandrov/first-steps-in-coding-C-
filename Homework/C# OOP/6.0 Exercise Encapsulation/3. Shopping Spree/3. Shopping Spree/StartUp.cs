using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            string[] personInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < personInfo.Length; i++)
            {
                string[] personNameAndMoney = personInfo[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = personNameAndMoney[0];
                decimal money = decimal.Parse(personNameAndMoney[1]);
                Person person = new Person(name, money);
                persons.Add(person);
            }
            string[] productInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productInfo.Length; i++)
            {
                string[] productNameAndcost = productInfo[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = productNameAndcost[0];
                decimal cost = decimal.Parse(productNameAndcost[1]);
                Product product = new Product(name, cost);
                products.Add(product);
            }
            string acttion = string.Empty;
            while ((acttion = Console.ReadLine()) != "END")
            {
                string[] personAndProduct = acttion.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string personName = personAndProduct[0];
                string productName = personAndProduct[1];
                
            }
        }
    }
}
