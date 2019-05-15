using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1._Vehicles
{
    public class Car : Vehicle
    {
        private const double additionalConsumption = 0.9;

        public Car(double fuelQuantity, double fuelCosuption, double tankCapacity)
            : base(fuelQuantity, fuelCosuption + additionalConsumption, tankCapacity)
        {
        }
    }
}
