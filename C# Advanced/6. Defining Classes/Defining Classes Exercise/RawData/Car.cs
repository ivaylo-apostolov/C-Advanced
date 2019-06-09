using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tire { get; set; }


        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Tire = new List<Tire>();
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tires;
        }

        public bool Fragile(Car car)
        {
            Tire checkCar = car.Tire.Where(t => t.TirePressure < 1).OrderBy(t => t.TirePressure).FirstOrDefault();

            if (checkCar != null && car.Cargo.CargoType == "fragile")
            {
                return true;
            }

            return false;
        }

        public bool Flamable(Car car)
        {
            if (car.Engine.EnginePower > 250 && car.Cargo.CargoType == "flamable")
            {
                return true;
            }

            return false;
        }
    }
}
