using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyAmount = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal lightsabersPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());
            decimal addSaber = (students * 10) / 100m;
            decimal castOfRobes = students * robesPrice;
            decimal castOfBelts = beltsPrice * students;
            decimal raundAddSabers = Math.Ceiling(addSaber);
            decimal castOfSabers = (students + raundAddSabers) * lightsabersPrice;
            decimal freeBelt = students / 6;
            int reduse = (int)Math.Floor(freeBelt);
            decimal castOfFreeBelts = reduse * beltsPrice;
            decimal allPrice = castOfBelts + castOfRobes + castOfSabers - castOfFreeBelts;
            //Console.WriteLine($"{castOfFreeBelts}");
            decimal moneyNeed = allPrice - moneyAmount;
            if (moneyAmount >= allPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {allPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {moneyNeed:f2}lv more.");
            }
        }
    }
}
