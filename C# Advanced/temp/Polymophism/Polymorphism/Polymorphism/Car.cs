using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Car : Vehicle
    {
        private const double increasedFuelConstuption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption + 0.9)
        {
        }
    }
}
