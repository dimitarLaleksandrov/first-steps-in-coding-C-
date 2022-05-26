using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class ParkingLot
    {
        static void Main(string[] args)
        {
            string input = " ";
            HashSet<string> set = new HashSet<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                string action = input.Split(", ")[0];
                string car = input.Split(", ")[1];
                if(action == "IN")
                {
                    set.Add(car);
                }
                else if (action == "OUT")
                {
                    if (set.Contains(car))
                    set.Remove(car);
                }
            }
            if (set.Count > 0)
            {
                foreach (string car in set)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
