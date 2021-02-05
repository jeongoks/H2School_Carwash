using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_ParkingSystem
{
    public class ParkingSystem
    {
        // Lists of the different Vehicle Types.
        private List<Car> CarLots { get; set; }

        private List<Truck> TruckLots { get; set; }

        private List<Trailer> TrailerLots { get; set; }

        private List<Disabled> DisabledLots { get; set; }

        // Constructor, where we're setting what the Max amount of Vehicles there can park depending on the Type.
        public ParkingSystem(int maxCars, int maxTruck, int maxTrailer, int maxDisabled)
        {
            this.CarLots = new List<Car>(maxCars);
            this.DisabledLots = new List<Disabled>(maxDisabled);
            this.TrailerLots = new List<Trailer>(maxTrailer);
            this.TruckLots = new List<Truck>(maxTruck);
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
                for (int i = 0; i < CarLots.Count; i++)
                {
                    if (CarLots[i] == null)
                    {
                        CarLots[i] = (Car)vehicle;
                        return new Ticket(vehicle);
                    }
                }
                return null;
            }
            #endregion
            #region If vehicle is of Type Truck.
            else if (vehicle.GetType() == typeof(Truck))
            {
                for (int i = 0; i < TruckLots.Count; i++)
                {
                    if (TruckLots[i] == null)
                    {
                        TruckLots[i] = (Truck)vehicle;
                        return new Ticket(vehicle);
                    }
                }
            }
            #endregion
            #region If vehicle is of Type Trailer.
            else if (vehicle.GetType() == typeof(Trailer))
            {
                for (int i = 0; i < TrailerLots.Count; i++)
                {
                    if (TrailerLots[i] == null)
                    {
                        TrailerLots[i] = (Trailer)vehicle;
                        return new Ticket(vehicle);
                    }
                }
            }
            #endregion
            #region If vehicle is of Type Diabled.
            else if (vehicle.GetType() == typeof(Disabled))
            {
                for (int i = 0; i < DisabledLots.Count; i++)
                {
                    if (DisabledLots[i] == null)
                    {
                        DisabledLots[i] = (Disabled)vehicle;
                        return new Ticket(vehicle);
                    }
                }
            }
            #endregion
            else
            {
                return null;
            }
            return new Ticket(vehicle);
        }

        public decimal CheckOut(Ticket ticket)
        {
            /// TODO: throw exception if vehicleType is not checked in
            /// TODO: calculate price + returning it.
        }
    }
}