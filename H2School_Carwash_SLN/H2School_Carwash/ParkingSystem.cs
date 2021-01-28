using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_Carwash
{
    public class ParkingSystem
    {
        private List<Car> CarLots { get; set; }

        private List<Truck> TruckLots { get; set; }

        private List<Trailer> TrailerLots { get; set; }

        private List<Disabled> DisabledLots { get; set; }

        public ParkingSystem(int maxCars, int maxDisabled, int maxTrailer, int maxTruck)
        {
            this.CarLots = new List<Car>(maxCars);
            this.DisabledLots = new List<Disabled>(maxDisabled);
            this.TrailerLots = new List<Trailer>(maxTrailer);
            this.TruckLots = new List<Truck>(maxTruck);
        }

        public Ticket CheckIn(Vehicle vehicleType)
        {
            // TODO: what type of vehicle?
            // TODO: throw exception if no room! or return null?
           
        }

        public decimal CheckOut(Ticket ticket)
        {
            // TODO: throw exception if vehicleType is not checked in
            // TODO: calculate price + returning it.
        }
    }
}