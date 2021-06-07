using System;

namespace Garage
{
    public class Cessna : GasGuzzler
    {
        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }
    }
}