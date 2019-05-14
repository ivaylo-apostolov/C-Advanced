using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Truck : Vehicle
    {
        private const double increasedFuelConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption + increasedFuelConsumption)
        {
        }
    }
}
