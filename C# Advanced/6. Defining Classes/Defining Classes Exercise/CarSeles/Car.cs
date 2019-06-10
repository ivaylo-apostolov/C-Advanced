using System;
using System.Collections.Generic;
using System.Text;

namespace CarSeles
{
    public class Car
    {
        private string model;

        private Engine engine;

        private string weight;

        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = "n/a";
            this.Weight = "n/a";
        }

        public string Model { get => model; set => model = value; }

        public Engine Engine { get => engine; set => engine = value; }

        public string Weight { get => weight; set => weight = value; }

        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return $"{this.Model}:" +
                Environment.NewLine +
                $"  {this.Engine.Model}:" +
                Environment.NewLine +
                $"    Power: {this.Engine.Power}" +
                Environment.NewLine +
                $"    Displacement: {this.Engine.Displacement}" +
                Environment.NewLine +
                $"    Efficiency: {this.Engine.Efficiency}" +
                Environment.NewLine +
                $"  Weight: {this.Weight}" +
                Environment.NewLine +
                $"  Color: {this.Color}";
        }

        
    }
}
