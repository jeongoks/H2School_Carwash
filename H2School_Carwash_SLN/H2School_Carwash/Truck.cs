using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_ParkingSystem
{
    public class Truck : Vehicle
    {
        public override decimal GetPrice()
        {
            return 30;
        }
    }
}