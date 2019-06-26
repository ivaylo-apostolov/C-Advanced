﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> data;

        public Restaurant(string name)
        {
            Name = name;
            this.data = new List<Salad>();
        }

        public string Name { get; set; }

        public void Add(Salad salad)
        {
            data.Add(salad);
        }

        public bool Buy(string name)
        {
            Salad salad = data.Where(s => s.Name == name).FirstOrDefault();

            if (salad != null)
            {
                data.Remove(salad);
                return true;
            }

            return false;
        }

        public Salad GetHealthiestSalad()
        {
            Salad salad = data.OrderBy(s => s.GetTotalCalories()).FirstOrDefault();

            return salad;
        }

        public string GenerateMenu()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Name} have {this.data.Count} salads:");

            foreach (var salad in data)
            {
                sb.AppendLine(salad.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
