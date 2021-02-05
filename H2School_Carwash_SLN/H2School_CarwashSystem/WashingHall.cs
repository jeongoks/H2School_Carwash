using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H2School_CarwashSystem
{
    public class WashingHall
    {
        public List<Vehicle> VehicleInHall { get; set; }

        public List<WashingType> WashingTypes { get; set; }

        public WashingHall(List<WashingType> types)
        {
            WashingTypes = new List<WashingType>();
            WashingTypes = types;
        }

        public void AddWashType(WashingType types)
        {
            WashingTypes.Add(types);
        }
    }
}