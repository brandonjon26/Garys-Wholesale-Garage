using System;

namespace Garage
{
    public class Tesla : ElectricVehicle
    {
        public override void Drive()
        {
            // base.Drive();
            Console.WriteLine($"I drive a modelS Tesla colored {MainColor}! Vrooooom.");
        }
    }
}