using System;
using System.Collections.Generic;
using System.Text;

namespace H2School_ParkingSystem
{
    class Program
    {
        static void Main()
        {
            ParkingSystem parkingSystem = new ParkingSystem(50, 12, 10, 5);

            while (true)
            {
                SystemMenu.Menu(parkingSystem);
            }
        }
    }
}
