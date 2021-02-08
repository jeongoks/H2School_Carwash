using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_ParkingSystem
{
    public class ParkingSystem
    {
        // Lists of the different Vehicle Types.
        private Car[] CarLots { get; set; }

        private Truck[] TruckLots { get; set; }

        private Trailer[] TrailerLots { get; set; }

        private Disabled[] DisabledLots { get; set; }

        private List<Ticket> TicketStorage { get; set; }

        // Constructor, where we're setting what the Max amount of Vehicles there can park depending on the Type.
        public ParkingSystem(int maxCars, int maxTruck, int maxTrailer, int maxDisabled)
        {
            this.CarLots = new Car[maxCars];
            this.DisabledLots = new Disabled[maxDisabled];
            this.TrailerLots = new Trailer[maxTrailer];
            this.TruckLots = new Truck[maxTruck];
            this.TicketStorage = new List<Ticket>();
        }

        /// <summary>
        /// This is the ticket the Customer will get, depending on their vehicle type.
        /// </summary>
        /// <param name="vehicle">Instance of Vehicle, the different types of vehicles.</param>
        /// <returns></returns>
        public Ticket CheckIn(Vehicle vehicle)
        {
            // Code deciding what Type of Vehicle there's getting Checked In to the Parking System.
            #region If vehicle is of Type Car.
            if (vehicle.GetType() == typeof(Car))
            {
                for (int i = 0; i < CarLots.Length; i++)
                {
                    if (CarLots[i] == null)
                    {
                        CarLots[i] = (Car)vehicle;
                        Ticket ticket = new Ticket(vehicle);
                        TicketStorage.Add(ticket);

                        return ticket;
                    }
                }
                return null;
            }
            #endregion
            #region If vehicle is of Type Truck.
            else if (vehicle.GetType() == typeof(Truck))
            {
                for (int i = 0; i < TruckLots.Length; i++)
                {
                    if (TruckLots[i] == null)
                    {
                        TruckLots[i] = (Truck)vehicle;
                        Ticket ticket = new Ticket(vehicle);
                        TicketStorage.Add(ticket);

                        return ticket;
                    }
                }
                return null;
            }
            #endregion
            #region If vehicle is of Type Trailer.
            else if (vehicle.GetType() == typeof(Trailer))
            {
                for (int i = 0; i < TrailerLots.Length; i++)
                {
                    if (TrailerLots[i] == null)
                    {
                        TrailerLots[i] = (Trailer)vehicle;
                        Ticket ticket = new Ticket(vehicle);
                        TicketStorage.Add(ticket);

                        return ticket;
                    }
                }
                return null;
            }
            #endregion
            #region If vehicle is of Type Diabled.
            else if (vehicle.GetType() == typeof(Disabled))
            {
                for (int i = 0; i < DisabledLots.Length; i++)
                {
                    if (DisabledLots[i] == null)
                    {
                        DisabledLots[i] = (Disabled)vehicle;
                        Ticket ticket = new Ticket(vehicle);
                        TicketStorage.Add(ticket);

                        return ticket;
                    }
                }
                return null;
            }
            #endregion
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This is where we Check out our Vehicle and return the Price * Hours.
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        public decimal CheckOut(string ticketNumber)
        {
            Ticket ticket = null;

            foreach (Ticket item in TicketStorage)
            {
                if (item.TicketId == ticketNumber)
                {
                    ticket = item;
                }
            }
            // If the Ticket Number doesn't exists, it throws an Exception.
            if (ticket == null)
            {
                throw new Exception("Something went wrong. Your Ticket Number doesn't exist.");
            }

            TicketStorage.Remove(ticket);

            #region Removing the Vehicle from the array.
            for (int i = 0; i < CarLots.Length; i++)
            {
                if (CarLots[i] == ticket.Vehicle)
                {
                    CarLots[i] = null;
                }
            }
            for (int i = 0; i < TrailerLots.Length; i++)
            {
                if (TrailerLots[i] == ticket.Vehicle)
                {
                    TrailerLots[i] = null;
                }
            }
            for (int i = 0; i < TruckLots.Length; i++)
            {
                if (TruckLots[i] == ticket.Vehicle)
                {
                    TruckLots[i] = null;
                }
            }
            for (int i = 0; i < DisabledLots.Length; i++)
            {
                if (DisabledLots[i] == ticket.Vehicle)
                {
                    DisabledLots[i] = null;
                }
            }
            #endregion

            return ticket.Vehicle.GetPrice() * (decimal)(DateTime.Now - ticket.ParkTime).TotalHours;
        }

        /// <summary>
        /// This is where we Check if there's any available lots depending on the Vehicle Type.
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int FreeLotsAvailable(Vehicle vehicle)
        {
            int freeLots = 0;

            #region If vehicle is of Type Car.
            if (vehicle.GetType() == typeof(Car))
            {
                for (int i = 0; i < CarLots.Length; i++)
                {
                    if (CarLots[i] == null)
                    {
                        freeLots++;
                    }
                }
                return freeLots;
            }
            #endregion
            #region If vehicle is of Type Truck.
            else if (vehicle.GetType() == typeof(Truck))
            {
                for (int i = 0; i < TruckLots.Length; i++)
                {
                    if (TruckLots[i] == null)
                    {
                        freeLots++;
                    }
                }
                return freeLots;
            }
            #endregion
            #region If vehicle is of Type Trailer.
            else if (vehicle.GetType() == typeof(Trailer))
            {
                for (int i = 0; i < TrailerLots.Length; i++)
                {
                    if (TrailerLots[i] == null)
                    {
                        freeLots++;
                    }
                }
                return freeLots;
            }
            #endregion
            #region If vehicle is of Type Diabled.
            else if (vehicle.GetType() == typeof(Disabled))
            {
                for (int i = 0; i < DisabledLots.Length; i++)
                {
                    if (DisabledLots[i] == null)
                    {
                        freeLots++;
                    }
                }
                return freeLots;
            }
            #endregion
            else
            {
                return -1;
            }
        }
    }
}