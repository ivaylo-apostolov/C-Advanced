using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }

        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }

        public Car()
        {
            this.make = "VW";
            this.model = "MK3";
            this.year = 1993;
            this.fuelQuantity = 50;
            this.fuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        
        public void Drive(double distance)
        {
            if ((this.fuelQuantity * this.fuelConsumption - distance) > 0)
            {
                this.fuelQuantity -= distance / this.fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public override string ToString()
        {
            return $"Make: {this.make}\nModel: {this.model}\nYear: {this.year}\nFuel: {this.fuelQuantity}L\nFuelConsuption: {this.fuelConsumption}";
        }
    }
}
