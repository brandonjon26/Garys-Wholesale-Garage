using System;

namespace Garage
{
    public class Cessna : GasGuzzler
    {
        public override void Drive()
        {
            Console.WriteLine($"This {MainColor} Cessna was a great investment! Time to take off!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"We had to make a {direction} turn before landing.");
        }

        public override void Stop()
        {
            Console.WriteLine("After hitting the strip easily, I rolled to a complete and safe stop. My first try too!");
        }
    }
}