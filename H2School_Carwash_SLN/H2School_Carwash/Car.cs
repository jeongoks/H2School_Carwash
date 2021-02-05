using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_ParkingSystem
{
    public class Car : Vehicle
    {
        public override decimal GetPrice()
        {
            return 15;
        }
    }
}