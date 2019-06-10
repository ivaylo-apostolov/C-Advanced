namespace CarSalesman
{
    public class Engine
    {
        private string model;

        private int power;

        private int? displacement;

        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = (int)displacement;
        }

        public string Model { get => model; set => model = value; }

        public int Power { get => power; set => power = value; }

        public int Displacement { get => (int)displacement; set => displacement = value; }

        public string Efficiency { get => efficiency; set => efficiency = value; }
    }
}