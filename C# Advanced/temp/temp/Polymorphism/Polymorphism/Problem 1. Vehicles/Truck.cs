using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1._Vehicles
{
    public class Truck : Vehicle
    {
        private const double additionalFuel = 1.6;

        public Truck(double fuelQuantity, double fuelCosuption, double tankCapacity) 
            : base(fuelQuantity, fuelCosuption + additionalFuel, tankCapacity)
        {
        }

       
    }
}
