using System;

namespace Garage
{
    public class Zero : ElectricVehicle  // Electric motorcycle
    {
        public override void Drive()
        {
            Console.WriteLine($"This {MainColor} Zero sucks! Hmmmmmm...");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"I made a {direction} back to the dealership. Why did I buy this car?");
        }

        public override void Stop()
        {
            Console.WriteLine("The car in front of me break checked me so I had to stop. Jerk!");
        }
    }
}