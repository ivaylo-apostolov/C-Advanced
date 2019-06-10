using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;

        private Engine engine;

        private double? weight;

        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = (double)weight;
            this.Color = "n/a";
        }

        public string Model { get => model; set => model = value; }

        public Engine Engine { get => engine; set => engine = value; }

        public double Weight { get => (double)weight; set => weight = value; }

        public string Color { get => color; set => color = value; }
    }
}
