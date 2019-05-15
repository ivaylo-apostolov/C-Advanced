using System;
using System.Collections.Generic;
using System.Text;

namespace AbsAndInterface
{
    public class Cat : IAnimal
    {
        public string Eat()
        {
            return "Cat is eating...";
        }

        public string Sleep()
        {
            return "Cat is sleeping .... zzzz";
        }
    }
}
