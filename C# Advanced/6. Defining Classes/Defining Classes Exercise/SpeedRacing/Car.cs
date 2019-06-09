using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKm;
        }

        public string Model { get => model; set => model = value; }
        public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public double FuelConsumptionPerKilometer { get => fuelConsumptionPerKilometer; set => fuelConsumptionPerKilometer = value; }
        public double TravelledDistance { get => travelledDistance; set => travelledDistance = value; }        

        public void Drive(double distance)
        {
            if (this.FuelAmount >= distance  * this.FuelConsumptionPerKilometer)
            {
                this.TravelledDistance += distance;
                this.FuelAmount -= distance * this.FuelConsumptionPerKilometer;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
        }
    }
}
