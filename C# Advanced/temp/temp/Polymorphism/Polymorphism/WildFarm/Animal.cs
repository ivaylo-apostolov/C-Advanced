using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten;

        public string Name { get => name; private set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int FoodEaten { get => foodEaten; set => foodEaten = value; }

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public abstract void Sound();

        public abstract void Eat(Food food);
    }
}
