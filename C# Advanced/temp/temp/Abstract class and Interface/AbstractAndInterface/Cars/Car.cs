using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car : IElectricCar, ICar
    {
        public int Battery { get; protected set; }

        public string Model { get; protected set; }

        public string Color { get; protected set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
    }
}
