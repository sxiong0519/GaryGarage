using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Vehicle> vehicles = new List<Vehicle>{
                new Zero {MainColor = "Red", MaximumOccupancy = 5},
                new Tesla {MainColor = "Yellow", MaximumOccupancy = 2},
                new Cessna {MainColor = "White", MaximumOccupancy = 5},
                new Ram {MainColor = "Black", MaximumOccupancy = 7}
            };


            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle.MainColor} {vehicle.GetType().Name} has {vehicle.MaximumOccupancy} seats. IT'S DRIVING PAST......");
                vehicle.Drive();
                vehicle.Turn("right");
                vehicle.Stop();
            }

            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            
        }
    }
}
