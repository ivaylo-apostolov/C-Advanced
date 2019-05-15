using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1._Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }

        public double FuelConsuptionInLitersPerKm { get; set; }

        public double TankCapacity { get; set; }

        public Vehicle(double fuelQuantity, double fuelCosuption, double tankCapacity)
        {
            if (this.FuelQuantity <= this.TankCapacity)
            {
                this.FuelQuantity = fuelQuantity;
            }
            else
            {
                this.FuelQuantity = 0;
            }
            this.FuelConsuptionInLitersPerKm = fuelCosuption;
            this.TankCapacity = tankCapacity;
        }

        public void Refuel(double refuel)
        {
            if (refuel > 0)
            {
                if (refuel <= this.TankCapacity && this.GetType().Name != "Truck")
                {
                    this.FuelQuantity += refuel;
                }
                else if (refuel <= this.TankCapacity && this.GetType().Name == "Truck")
                {
                    this.FuelQuantity += refuel * 0.95;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {refuel} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }

        public string Drive(string name, double distance)
        {
            if (distance <= this.FuelQuantity / this.FuelConsuptionInLitersPerKm
                && name != "DriveBus")
            {
                this.FuelQuantity -= distance * this.FuelConsuptionInLitersPerKm;
                return $"{this.GetType().Name} travelled {distance:f2} km";
            }
            if (distance <= this.FuelQuantity / this.FuelConsuptionInLitersPerKm
                && name == "DriveBus")
            {
                this.FuelConsuptionInLitersPerKm += 1.4;
                this.FuelQuantity -= distance * this.FuelConsuptionInLitersPerKm;
                return $"{this.GetType().Name} travelled {distance:f2} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
