using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08._SoftUni_Party
{
    internal class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vipGuestsg = new HashSet<string>();
            Regex pattern = new Regex(@"^\d");
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "PARTY")
                {
                    break;
                }
                if (pattern.IsMatch(guest))
                {
                    vipGuestsg.Add(guest);
                }
                else
                {
                    guests.Add(guest);
                }
            }
            while (true)
            {
                string guestAraived = Console.ReadLine();
                if (guestAraived == "END")
                {
                    break;
                }
                if (vipGuestsg.Contains(guestAraived))
                {
                    vipGuestsg.Remove(guestAraived);
                }
                else if (guests.Contains(guestAraived))
                {
                    guests.Remove(guestAraived);
                }
            }
            int numOfPplThatHaventCome = vipGuestsg.Count + guests.Count;
            Console.WriteLine(numOfPplThatHaventCome);
            foreach (string vip in vipGuestsg)
            {
                Console.WriteLine(vip);
            }
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
