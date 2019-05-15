using System;
using System.Collections.Generic;
using System.Text;

namespace CatAndDogs
{
    public class Puppy : Dog
    {
        public Puppy(string name, int age)
            :base(name, age)
        {
        }

        public string Weed()
        {
            return "Weed!";
        }
    }
}
