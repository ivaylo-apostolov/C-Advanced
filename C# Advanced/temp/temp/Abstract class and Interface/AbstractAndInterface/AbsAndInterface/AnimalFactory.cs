using System;
using System.Collections.Generic;
using System.Text;

namespace AbsAndInterface
{
    public static class AnimalFactory
    {
        public static Animal Create(string name)
        {
            return new Dog(name);
        }
    }
}
