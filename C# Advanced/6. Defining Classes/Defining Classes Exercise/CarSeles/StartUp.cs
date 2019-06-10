using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSeles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split();

                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                string displacement = string.Empty;
                string efficiency = string.Empty;

                Engine engine = new Engine(model, power);

                if (tokens.Length > 2)
                {
                    string temp = tokens[2];
                    if (char.IsDigit(temp[0]))
                    {
                        displacement = temp;
                        engine.Displacement = displacement;
                    }
                    else if (char.IsLetter(temp[0]))
                    {
                        efficiency = temp;
                        engine.Efficiency = efficiency;
                    }
                }

                if (tokens.Length > 3)
                {
                    string temp = tokens[3];
                    if (char.IsDigit(temp[0]))
                    {
                        displacement = temp;
                        engine.Displacement = displacement;
                    }
                    else if (char.IsLetter(temp[0]))
                    {
                        efficiency = temp;
                        engine.Efficiency = efficiency;
                    }
                }

                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var token = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = token[0];
                string engine = token[1];
                string weight = string.Empty;
                string color = string.Empty;

                Engine newEngine = engines.Where(e => e.Model == engine).FirstOrDefault();

                Car car = new Car(model, newEngine);

                if (token.Length > 2)
                {
                    string temp = token[2];

                    if (char.IsDigit(temp[0]))
                    {
                        weight = temp;
                        car.Weight = weight;
                    }
                    else if (char.IsLetter(temp[0]))
                    {
                        color = temp;
                        car.Color = color;
                    }
                }

                if (token.Length > 3)
                {
                    string temp = token[3];

                    if (char.IsDigit(temp[0]))
                    {
                        weight = temp;
                        car.Weight = weight;
                    }
                    else if (char.IsLetter(temp[0]))
                    {
                        color = temp;
                        car.Color = color;
                    }
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
