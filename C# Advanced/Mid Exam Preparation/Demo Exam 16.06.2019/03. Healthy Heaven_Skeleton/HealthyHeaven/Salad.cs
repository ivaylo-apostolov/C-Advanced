using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> vegetables;

        public Salad(string name)
        {
            this.vegetables = new List<Vegetable>();
            Name = name;
        }

        public string Name { get; set; }

        public List<Vegetable> ListVegetables()
        {
            return vegetables;
        }

        public int GetTotalCalories()
        {
            List<int> listCalories = vegetables.Select(v => v.Calories).ToList();
            return listCalories.Sum();
        }

        public int GetProductCount()
        {
            return vegetables.Count;
        }

        public void Add(Vegetable product)
        {
            vegetables.Add(product);
        }

        public void PrintVegetables()
        {
            foreach (var vegetable in vegetables)
            {
                Console.WriteLine(vegetable.Name);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"* Salad {this.Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            for(int i = 0; i < vegetables.Count; i++)
            {
                if (i != vegetables.Count - 1)
                {
                    sb.AppendLine($" - {vegetables[i].Name} have {vegetables[i].Calories} calories");
                }
                else
                {
                    sb.Append($" - {vegetables[i].Name} have {vegetables[i].Calories} calories");
                }
                
            }

            return sb.ToString();              
        }
    }
}
