using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> salads;

        public Restaurant(string name)
        {
            this.Name = name;
            this.salads = new List<Salad>();    
        }

        public string Name { get; set; }

        public void Add(Salad salad)
        {
            salads.Add(salad);
        }

        public bool Buy(string name)
        {
            Salad salad = salads.Where(s => s.Name == name).FirstOrDefault();

            if (salad != null)
            {
                return true;
            }

            return false;
        }

        public string GetHealthiestSalad()
        {
            return salads.OrderBy(s => s.GetTotalCalories()).FirstOrDefault().Name;
        }

        

        public string GenerateMenu()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Name} have {salads.Count} salads:");

            foreach (var salad in salads)
            {
                sb.AppendLine(salad.ToString());                
            }

            return sb.ToString();
        }
    }
}
