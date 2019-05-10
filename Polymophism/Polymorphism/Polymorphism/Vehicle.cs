using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Vehicle
    {        
        public double FuelQuantity { get; set; }

        public double FuelConsumptionInLitersPerKm { get; set; }

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionInLitersPerKm = fuelConsumption;
        }       

        public string Drive(double distance)
        {
            if (distance <= this.FuelQuantity / this.FuelConsumptionInLitersPerKm)
            {
                this.FuelQuantity -= distance * this.FuelConsumptionInLitersPerKm;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public void Refueling(double refuelQuantity)
        {
            if (this.GetType().Name == "Car")
            {
                this.FuelQuantity += refuelQuantity;
            }
            else if (this.GetType().Name == "Truck")
            {
                this.FuelQuantity += refuelQuantity * 0.95;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
