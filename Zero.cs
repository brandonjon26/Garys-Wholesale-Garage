using System;

namespace Garage
{
    public class Zero : ElectricVehicle  // Electric motorcycle
    {
        public override void Drive()
        {
            Console.WriteLine($"This {MainColor} Zero sucks! Hmmmmmm...");
        }
    }
}