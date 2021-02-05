using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_ParkingSystem
{
    public class Ticket
    {
        private static int Id { get; set; }
        public string TicketId { get; private set; }
        public Vehicle Vehicle { get; set; }

        public DateTime ParkTime { get; set; }

        public Ticket(Vehicle v)
        {
            this.Vehicle = v;
            this.ParkTime = DateTime.Now;
            this.TicketId = GetNextId();
        }

        private static string GetNextId()
        {
            return (++Id).ToString();
        }
    }
}