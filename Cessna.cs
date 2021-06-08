using System;

namespace Garage
{
    public class Cessna : GasGuzzler
    {
        public override void Drive()
        {
            Console.WriteLine($"This {MainColor} Cessna was a great investment! Time to take off!");
        }
    }
}