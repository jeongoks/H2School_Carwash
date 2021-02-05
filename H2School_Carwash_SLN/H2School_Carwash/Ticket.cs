using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_ParkingSystem
{
    public class Ticket
    {
        private Vehicle Vehicle { get; set; }

        private DateTime ParkTime { get; set; }

        public Ticket(Vehicle v)
        {
            this.Vehicle = v;
        }
    }
}