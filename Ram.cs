using System;

namespace Garage
{
    public class Ram : GasGuzzler // Gas powered truck
    {
        public override void Drive()
        {
            Console.WriteLine($"I'm thinking about buying a {MainColor} Ram. Lets test drive it! RRRrrrruuummbbleeee.");
        }
    }
}