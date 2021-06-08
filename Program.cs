using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 10,
                MainColor = "black",
                MaximumOccupancy = 2
            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 100,
                MainColor = "blue",
                MaximumOccupancy = 5
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 57,
                MainColor = "white",
                MaximumOccupancy = 4
            };
            Ram model500 = new Ram()
            {
                FuelCapacity = 25,
                MainColor = "red",
                MaximumOccupancy = 5
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            model500.Drive();
        }
    }
}









//  Zero fxs = new Zero();
//             Zero fx = new Zero();
//             Tesla modleS = new Tesla();


//             List<Zero> electronicVehicles = new List<Zero>() { fx, fxs };
