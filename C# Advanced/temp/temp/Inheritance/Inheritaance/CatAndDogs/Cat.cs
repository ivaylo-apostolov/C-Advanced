using System;
using System.Collections.Generic;
using System.Text;

namespace CatAndDogs
{
    public class Cat : Animal
    {
        public Cat(string name, int age)
            :base(name, age)
        {

        }

        public string SayMeau()
        {
            return "Meau-meau";
        }
    }
}
