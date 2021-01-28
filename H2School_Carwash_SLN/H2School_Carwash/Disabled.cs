using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_Carwash
{
    public class Disabled : Vehicle
    {
        public override decimal GetPrice()
        {
            return 10;
        }
    }
}