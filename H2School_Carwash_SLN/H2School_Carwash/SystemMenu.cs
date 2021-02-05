using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_ParkingSystem
{
    public class SystemMenu
    { 
        public static void Menu(ParkingSystem parking)
        {
            string menuSelect = "";

            Console.WriteLine("---------------------------------");
            Console.WriteLine("  What can we do for you today?");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Check in your vehicle.\n2. Check for Lots available.\n3. Check out your vehicle.");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Enter your Selection:");
            menuSelect = Console.ReadLine();

            switch (menuSelect)
            {
                case "1":
                    CheckInMenu(parking);
                    break;
                case "2":
                    CheckAvailableLots(parking);
                    break;
                case "3":
                    CheckOutMenu(parking);
                    break;
            }
        }

        /// <summary>
        /// Menu System of when a customer is checking in their Vehicle to the Parking lot.
        /// </summary>
        /// <param name="parking">What type of parking you want to add.</param>
        public static void CheckInMenu(ParkingSystem parking)
        {
            string menuSelect = "";

            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Which kind of car would you like to check in?");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. Regular Car.\n2. Car with a Trailer.\n3. Truck or Bus.\n4. Disabled parking.\n5. Return to Main Menu.");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Enter your Selection:");
            menuSelect = Console.ReadLine();

            Ticket ticket = null;

            #region Switch Case to Check In.
            switch (menuSelect)
            {
                case "1":
                    ticket = parking.CheckIn(new Car());
                    break;
                case "2":
                    ticket = parking.CheckIn(new Trailer());
                    break;
                case "3":
                    ticket = parking.CheckIn(new Truck());
                    break;
                case "4":
                    ticket = parking.CheckIn(new Disabled());
                    break;
                case "5":
                    Menu(parking);
                    break;
            }
            #endregion

            if (ticket == null)
            {
                Console.WriteLine("There wasn't any available parking lots.\nCome back again later.");
            }
            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Check in succesful.");
            }
        }

        /// <summary>
        /// Menu System where a customer checks the available lots.
        /// </summary>
        /// <param name="parking"></param>
        public static void CheckAvailableLots(ParkingSystem parking)
        {
            string menuSelect = "";

            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Choose a specific Parking Lot you'd want to check.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Regular Car.\n2. Car with a Trailer.\n3. Truck or Bus.\n4. Disabled parking.\n5. Return to Main Menu.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Enter your Selection:");
            menuSelect = Console.ReadLine();

            int freeLots = 0;

            #region Switch Case for Menu.
            switch (menuSelect)
            {
                case "1":
                    freeLots = parking.FreeLotsAvailable(new Car());
                    break;
                case "2":
                    freeLots = parking.FreeLotsAvailable(new Trailer());
                    break;
                case "3":
                    freeLots = parking.FreeLotsAvailable(new Truck());
                    break;
                case "4":
                    freeLots = parking.FreeLotsAvailable(new Disabled());
                    break;
                case "5":
                    Menu(parking);
                    break;
            }
            #endregion

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"There are {freeLots} available lots.");
        }

        /// <summary>
        /// Menu System where a customer Checks out of the Parking system.
        /// </summary>
        /// <param name="parking"></param>
        public static void CheckOutMenu(ParkingSystem parking)
        {
            string ticketNumber = "";
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter your ticket number:");
            ticketNumber = Console.ReadLine();

            decimal price = parking.CheckOut(ticketNumber);

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"  Your price will be: ${Decimal.Round(price, 2)}.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("    Thank you for visiting!");
        }
    }
}
