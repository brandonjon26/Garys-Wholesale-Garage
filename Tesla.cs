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

        public override void Turn(string direction)
        {
            Console.WriteLine($"I zipped {direction} around the corner in this sweet new Tesla!");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping in this car is super easy!");
        }
    }
}