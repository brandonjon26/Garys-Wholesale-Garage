using System;

namespace Garage
{
    public class Tesla : ElectricVehicle
    {
        public override void Drive()
        {
            // base.Drive();
            Console.WriteLine($"I drive a modelS colored {MainColor} that has a wattage of {BatteryKWh} and fits {MaximumOccupancy}.");
        }
    }
}