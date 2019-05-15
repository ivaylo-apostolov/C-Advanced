using System;
using System.Collections.Generic;
using System.Text;

namespace AbsAndInterface
{
    public class Dog : Animal
    {
        public Dog(string name)
            :base(name)
        {

        }

        public override string Sleeping()
        {
            return "Dog is sleeping...";
        }
    }
}
