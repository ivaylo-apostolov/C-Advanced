using System;
using System.Collections.Generic;
using System.Text;

namespace CatAndDogs
{
    public class Dog : Animal
    {
        public Dog(string name, int age)
            :base(name, age)
        {

        }

        public string SayJaf()
        {
            return "Jaf-jaf";
        }
    }
}
