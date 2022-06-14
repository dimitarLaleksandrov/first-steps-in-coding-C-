using System;
using System.Collections.Generic;
using System.Linq;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //var lineNums = int.Parse(Console.ReadLine());
            //var list = new List<int>();
            //for (int i = 1; i <= lineNums; i++)
            //{
            //    var input = int.Parse(Console.ReadLine());
            //    list.Add(input);
            //}
            //var box = new Box<int>(list);
            //var indexses = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //box.Swap(list, indexses[0], indexses[1]);
            //Console.WriteLine(box);
            //var list = new List<double>();
            //for (int i = 1; i <= lineNums; i++)
            //{
            //    var input = double.Parse(Console.ReadLine());
            //    list.Add(input);
            //}
            //var box = new Box<double>(list);
            //var compareElement = double.Parse(Console.ReadLine());
            //var count = box.Count(list, compareElement);
            //Console.WriteLine(count);
            //var personInfo = Console.ReadLine().Split();
            //var fullName = $"{personInfo[0]} {personInfo[1]}";
            //var city = $"{personInfo[2]}";
            //var nameAndBeer = Console.ReadLine().Split();
            //var name = nameAndBeer[0];
            //var litters = int.Parse(nameAndBeer[1]);
            //var numbersInput = Console.ReadLine().Split();
            //var intNum = int.Parse(numbersInput[0]);
            //var doubleNum = double.Parse(numbersInput[1]);
            //Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, city);
            //Tuple<string, int> secondTuple = new Tuple<string, int>(name, litters);
            //Tuple<int, double> thirdTuple = new Tuple<int, double>(intNum, doubleNum);
            //Console.WriteLine(firstTuple);
            //Console.WriteLine(secondTuple);
            //Console.WriteLine(thirdTuple);
            var personInfo = Console.ReadLine().Split();
            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var adres = $"{personInfo[2]}";
            var city = personInfo.Length > 4 ? $"{personInfo[3]} {personInfo[4]}" : $"{personInfo[3]}";
            var nameAndBeer = Console.ReadLine().Split();
            var name = nameAndBeer[0];
            var litters = int.Parse(nameAndBeer[1]);
            var drunkOrNot = nameAndBeer[2] == "drunk" ? true : false;
            var bankInfo = Console.ReadLine().Split();
            var personName = bankInfo[0];
            var balance = double.Parse(bankInfo[1]);
            var bankName = bankInfo[2];
            Threeuple<string, string, string> firstThreeuple = new Threeuple<string, string, string>(fullName, adres, city);
            Threeuple<string, int, bool> secondThreeuple = new Threeuple<string, int, bool>(name, litters, drunkOrNot);
            Threeuple<string, double, string> thirdTThreeuple = new Threeuple<string, double, string>(personName, balance, bankName);
            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdTThreeuple);
        }
    }
}
