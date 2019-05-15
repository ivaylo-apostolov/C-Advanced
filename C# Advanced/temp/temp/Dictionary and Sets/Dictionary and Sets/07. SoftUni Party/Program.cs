using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexRegularGuest = @"^[\w]{8}$";
            string regexVIPGuest = @"^[\d]{1}[\w]{7}$";

            var vipGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            string guestsInLists = string.Empty;

            while ((guestsInLists = Console.ReadLine()) != "PARTY")
            {
                if (Regex.IsMatch(guestsInLists, regexVIPGuest))
                {
                    vipGuests.Add(guestsInLists);
                }
                else if (Regex.IsMatch(guestsInLists, regexRegularGuest))
                {
                    regularGuests.Add(guestsInLists);
                }
            }

            string guestComing = string.Empty;

            while ((guestComing = Console.ReadLine()) != "END")
            {
                if (vipGuests.Contains(guestComing))
                {
                    vipGuests.Remove(guestComing);
                }
                else if (regularGuests.Contains(guestComing))
                {
                    regularGuests.Remove(guestComing);
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }

            foreach (var regularGuest in regularGuests)
            {
                Console.WriteLine(regularGuest);
            }
        }
    }
}
