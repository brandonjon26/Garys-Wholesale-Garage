using System;

namespace Garage
{
    public class Ram : GasGuzzler // Gas powered truck
    {
        public override void Drive()
        {
            Console.WriteLine($"I'm thinking about buying a {MainColor} Ram. Lets test drive it! RRRrrrruuummbbleeee.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"I had to be careful when I made a {direction} turn. I almost flipped my Ram!");
        }

        public override void Stop()
        {
            Console.WriteLine("I couldn't stop in time so I absolutely demolished that Zero in front of me.");
        }
    }
}