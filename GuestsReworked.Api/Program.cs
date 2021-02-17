using System;
using System.Collections.Generic;
using GuestsReworked.Api.Models;

namespace GuestsReworked.Api
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();
        
        static void Main(string[] args)
        {
            GetGuestInfo();
            PrintGuestInfo();
            // Console.WriteLine("Hey thereeeee!!!!!!");
        }

        static void PrintGuestInfo()
        {
            foreach (var guest in guests)
            {
                Console.WriteLine($"{guest.FirstName} {guest.LastName} said: {guest.MessageToHost}");
            }
        }

        static void GetGuestInfo()
        {
            string moreGuestsComing = "";
            do
            {
                GuestModel guest = new GuestModel();
                Console.Write("What's your first name? \n");
                guest.FirstName = Console.ReadLine();
                Console.Write("What's your last name? \n");
                guest.LastName = Console.ReadLine();
                Console.Write("What's your message to the host? \n");
                guest.MessageToHost = Console.ReadLine();
                Console.Write("Are there more guests coming? yes/no \n");
                moreGuestsComing = Console.ReadLine();
                
                guests.Add(guest);
                Console.Clear();
            } while (moreGuestsComing.ToLower() == "yes");
        }
    }
}

