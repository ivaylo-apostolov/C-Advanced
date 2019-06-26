using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> products;

        public Salad(string name)
        {
            Name = name;
            this.products = new List<Vegetable>();
        }

        public string Name { get; set; }

        public int GetTotalCalories()
        {
            int calories = 0;

            foreach (var cal in products)
            {
                calories += cal.Calories;
            }

            return calories;
        }

        public int GetProductCount()
        {
            return products.Count;
        }

        public void Add(Vegetable product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"* Salad {this.Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            foreach (var vegetable in products)
            {
                sb.AppendLine(vegetable.ToString());
            }

            return sb.ToString().TrimEnd();
        }


    }
}
