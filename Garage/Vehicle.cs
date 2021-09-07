using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"It is turning... {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("It slams on the brakes in attempt to stop at the stop sign.");
        }
    }
}

