﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal : IMammal
    {
        public string Name { get; set; }

        public string FavouriteFood { get; set; }

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }

        public virtual string Wallking()
        {
            return $"My name is {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
