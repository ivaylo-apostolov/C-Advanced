using System;
using System.Collections.Generic;
using System.Text;

namespace CatAndDogs
{
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
}
