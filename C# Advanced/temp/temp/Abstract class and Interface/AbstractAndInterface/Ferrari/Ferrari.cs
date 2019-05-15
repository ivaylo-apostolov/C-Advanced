using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        private string model = "488-Spider";
        private string driver;

        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Driver { get => driver; private set => driver = value; }

        public string Break()
        {
            return "Breaks!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{this.model}/{Break()}/{Gas()}/{this.driver}";
        }
    }
}
