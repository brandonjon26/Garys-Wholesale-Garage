using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
        }
    }
}









//  Zero fxs = new Zero();
//             Zero fx = new Zero();
//             Tesla modleS = new Tesla();


//             List<Zero> electronicVehicles = new List<Zero>() { fx, fxs };
